using LabManager.BarcodeScaner;
using LabManagerCliente;
using LabManagerCliente.PrestamoRecepcionService;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LabManager
{
    partial class Vprincipal
    {
        
        private void OnCodigoBarras(CodigoBarras Codigo, bool IngresoManual)
        {
            this.Enabled = false;
            setActive = false;
            try
            {
                timersReset = true;
                if (!Codigo.EsEquipo)
                {
                    Informacion_Usuario(Codigo.Codigo);
                }
                else
                {
                    Informacion_Equipo(Codigo.Codigo, IngresoManual);
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("OnCodigoBarras", ex.Message);
            }
            setActive = true;
            this.Enabled = true;
        }

        private bool VistaRestricciones(string Codigo)
        {
            var Lista = AdministradorEquipoCliente.getEquipos(Codigo, null);
            //var UserR = Lista.Items[0].UsuarioResponsable;
            string UserR = null;
            for (int a = 0; a < Lista.Items.Length; a++)
            {
                if (Lista.Items[a].CodigoInventario == Codigo.ToUpper() || Lista.Items[a].CodigoLaboratorio == Codigo.ToUpper()
                    || Lista.Items[a].CodigoInventario == Codigo.ToLower() || Lista.Items[a].CodigoLaboratorio == Codigo.ToLower())
                {
                    UserR = Lista.Items[a].UsuarioResponsable;
                }
            }

            if (!string.IsNullOrEmpty(UserR))
            {
                return false;
            }
            var Restricciones = PrestamoRecepcionCliente.getRestriccionesEquipo(Codigo);
            if (Restricciones.Restricciones != null)
            {
                string TxRestricciones = null;
                for (int a = 0; a < Restricciones.Restricciones.Length; a++)
                {
                    TxRestricciones += "-" + Restricciones.Restricciones[a].Texto + "\r\n";
                }
                var Rsts = new LabManager.PrestamoRecepcion.Restricciones(TxRestricciones);
                tLogOut.Stop();
                tClear.Stop();
                DialogResult Resultado = Rsts.ShowDialog();
                tLogOut.Start();
                tClear.Start();
                if (Resultado == DialogResult.No)
                {
                    Tb_Codigo_equipo.Text = null;
                    return true;
                }
            }
            return false;
        }

        private void Informacion_Equipo(string CodBarr, bool IngresoManual)
        {
            try
            {
                if (usuario != null&&!string.IsNullOrEmpty(Tb_Nombres.Text))
                {
                    if (VistaRestricciones(CodBarr))
                    {
                        return;
                    }
                    View_EquiposACargo Equipo = PrestamoRecepcionCliente.PrestarRecibirEquipo(
                        (int)usuario.UsuarioId, (int)Auxiliar.UsuarioId, usuario.FacultadId, usuario.SemestreBasico, CodBarr, IngresoManual);
                    if (Equipo.Prestado)
                    {
                        var lista = usuario.Equipos.ToList();
                        lista.Add(Equipo);
                        usuario.Equipos = lista.ToArray();
                        usuario.nEquipos++;
                    }
                    else
                    {
                        usuario.Equipos = usuario.Equipos.Where(e => e.CodigoLaboratorio != Equipo.CodigoLaboratorio).ToArray();
                        usuario.nEquipos--;
                    }

                    var formConfirma = new PrestamoRecepcion.IngresoEgresoForm();
                    formConfirma.equipo = Equipo;
                    formConfirma.ShowDialog();
                    ActualizacioEquiposLista();
                    FocoDeseado = EstadoFoco.CodEquipo;
                }
                else
                {
                    Mensaje.Error("Error", "Ingrese un Codigo de usuario primero");
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Error", ex.Message);
            }
            Tb_Codigo_equipo.Text = "";
        }

        public void Informacion_Usuario(string CodBarr)
        {
            try
            {
                usuario = PrestamoRecepcionCliente.getInfoPrestamoRecepcion(CodBarr);
                if (usuario.Error == false)
                {
                    ClearPantalla();
                    Tb_Codigo_usuario.Text = CodBarr;
                    Tb_Codigo_usuario.SelectAll();
                    Tb_Codigo_equipo.Text = "";
                    if (usuario.TipoUsuarioId == 2)
                    {
                        Seguridad.CacheUsuarios cu = new Seguridad.CacheUsuarios();
                        if (cu.Exist(usuario.BarCode))
                        {
                            try
                            {
                                var result = SeguridadCliente.Validar(usuario.BarCode, cu.getLastPassword(usuario.BarCode));
                                Auxiliar = result;
                            }
                            catch {
                                this.Close();
                            }
                        }
                        else {
                            this.Close();
                        }
                    }

                    if (!usuario.Activo) {
                        var pregunta = new PrestamoRecepcion.SiNo("Activación rápida", "El estudiante está inactivo. ¿Desea activarlo?");
                        if (pregunta.ShowDialog() == DialogResult.Yes)
                        {
                            InactivarEstudianteCliente.ActivarEstudiantes(Auxiliar.UsuarioId, usuario.UsuarioId);
                        }else
                        {
                            throw new Exception("Estudiante inactivo.");
                        }
                    }

                    if (usuario.nMultas > 0)
                        Mensaje.Error("Multas", "El usuario tiene multas");
                    if (usuario.nAnotaciones > 0)
                        Mensaje.Error("Anotaciones", "El usuario tiene anotaciones");

                    Tb_Nombres.Text = usuario.Nombres;
                    Tb_Apellidos.Text = usuario.Apellidos;
                    Tb_Facultad.Text = usuario.Facultad;
                    Btn_Nequipos.Text = usuario.nEquipos + " Equipos";
                    if (usuario.nAnotaciones != 0)
                    {
                        string TexAnotaciones = "";
                        for (int a = 0; a < usuario.nAnotaciones; a++)
                        {
                            TexAnotaciones = TexAnotaciones + "-" + usuario.Anotaciones[a].Descripcion + "\r\n";
                        }
                        Tb_Anotaciones.Text = TexAnotaciones;
                    }
                    if (usuario.nMultas != 0)
                    {
                        string TexMultas = "";
                        for (int a = 0; a < usuario.nMultas; a++)
                        {
                            TexMultas = TexMultas + "-" + usuario.Multas[a].Descripcion + "\r\n";
                        }
                        Tb_Multas.Text = TexMultas;
                    }
                    ActualizacioEquiposLista();
                    FocoDeseado = EstadoFoco.CodEquipo;
                }
                else
                {
                    ClearPantalla();
                    Mensaje.Informacion("Usuario", "El usuario no está activo ");
                    usuario = null;
                    FocoDeseado = EstadoFoco.CodUsuario;
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("Buscando usuario", ex.Message);
                Tb_Codigo_usuario.Text = "";
                Btn_Nequipos.Text = "Equipos";
                FocoDeseado = EstadoFoco.CodUsuario;
            }
        }

        private void ActualizacioEquiposLista()
        {
            try
            {
                if (usuario.Equipos != null)
                {
                    DataGV_Equipos.Rows.Clear();
                    foreach (var Equipos in usuario.Equipos)
                    {
                        DataGV_Equipos.Rows.Add(Equipos.TipoEquipo, Equipos.CodigoLaboratorio);
                    }
                    for (int a = 0; a < usuario.nEquipos; a++)
                    {
                        DataGridViewRow Row = DataGV_Equipos.Rows[a];
                        Row.Height = 50;
                    }
                    Btn_Nequipos.Text = usuario.nEquipos + " Equipos";
                    Gb_Equipos.Text = "Equipos "+usuario.nEquipos;
                    DataGV_Equipos.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                Mensaje.Error("ActualizacioEquiposLista", ex.Message);
            }
        }
    }
}
