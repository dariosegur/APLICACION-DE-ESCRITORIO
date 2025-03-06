using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LabManagerCliente
{
    public class AdministradorAdministrativoCliente{
        private static AdministradorAdministrativoService.AdministradorAdministrativoClient cliente =
            new AdministradorAdministrativoService.AdministradorAdministrativoClient();
        public static LabManagerCliente.AdministradorAdministrativoService.Lista_View_Administrativo getAdministrativos(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getAdministrativos(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorAdministrativoService.DtoBase AddAdministrativo(LabManagerCliente.AdministradorAdministrativoService.View_Administrativo newAdministrativo)
		{
            var resultado = cliente.AddAdministrativo(newAdministrativo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorAdministrativoService.DtoBase EditAdministrativo([System.ServiceModel.MessageParameterAttribute(Name="editAdministrativo")] LabManagerCliente.AdministradorAdministrativoService.View_Administrativo editAdministrativo1)
		{
            var resultado = cliente.EditAdministrativo(editAdministrativo1);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class AdministradorAnotacionCliente{
        private static AdministradorAnotacionService.AdministradorAnotacionClient cliente =
            new AdministradorAnotacionService.AdministradorAnotacionClient();
        public static LabManagerCliente.AdministradorAnotacionService.Lista_View_Anotaciones getAnotaciones(long UsuarioId)
		{
            var resultado = cliente.getAnotaciones(UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorAnotacionService.DtoBase AddAnotacion(LabManagerCliente.AdministradorAnotacionService.View_Anotaciones newAnotacion)
		{
            var resultado = cliente.AddAnotacion(newAnotacion);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorAnotacionService.DtoBase EditAnotacion([System.ServiceModel.MessageParameterAttribute(Name="editAnotacion")] LabManagerCliente.AdministradorAnotacionService.View_Anotaciones editAnotacion1)
		{
            var resultado = cliente.EditAnotacion(editAnotacion1);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorAnotacionService.Lista_View_EstadoAnotacion getEstadosAnotacion()
		{
            var resultado = cliente.getEstadosAnotacion();
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class AdministradorAuxiliarCliente{
        private static AdministradorAuxiliarService.AdministradorAuxiliarClient cliente =
            new AdministradorAuxiliarService.AdministradorAuxiliarClient();
        public static LabManagerCliente.AdministradorAuxiliarService.Lista_View_Auxiliar getAuxiliares(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getAuxiliares(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorAuxiliarService.Lista_View_Auxiliar_Activo getAuxiliaresActivos()
		{
            var resultado = cliente.getAuxiliaresActivos();
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorAuxiliarService.DtoBase AddAuxiliar(LabManagerCliente.AdministradorAuxiliarService.View_Auxiliar newAuxiliar)
		{
            var resultado = cliente.AddAuxiliar(newAuxiliar);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorAuxiliarService.DtoBase EditAuxiliar([System.ServiceModel.MessageParameterAttribute(Name="editAuxiliar")] LabManagerCliente.AdministradorAuxiliarService.View_Auxiliar editAuxiliar1)
		{
            var resultado = cliente.EditAuxiliar(editAuxiliar1);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class AdministradorDocenteCliente{
        private static AdministradorDocenteService.AdministradorDocenteClient cliente =
            new AdministradorDocenteService.AdministradorDocenteClient();
        public static LabManagerCliente.AdministradorDocenteService.Lista_View_Docentes getDocentes(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getDocentes(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorDocenteService.DtoBase AddDocente(LabManagerCliente.AdministradorDocenteService.View_Docente newDocente)
		{
            var resultado = cliente.AddDocente(newDocente);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorDocenteService.DtoBase EditDocente([System.ServiceModel.MessageParameterAttribute(Name="editDocente")] LabManagerCliente.AdministradorDocenteService.View_Docente editDocente1)
		{
            var resultado = cliente.EditDocente(editDocente1);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorDocenteService.Lista_View_Facultad getFacultad(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getFacultad(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorDocenteService.Lista_View_Historial_Docente getHistorialBasico(long UsuarioId, System.DateTime FechaInicio, System.DateTime FechaFin)
		{
            var resultado = cliente.getHistorialBasico(UsuarioId,FechaInicio,FechaFin);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class AdministradorEquipoCliente{
        private static AdministradorEquipoService.AdministradorEquipoClient cliente =
            new AdministradorEquipoService.AdministradorEquipoClient();
        public static LabManagerCliente.AdministradorEquipoService.Lista_View_Equipo getEquipos(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getEquipos(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorEquipoService.DtoBase AddEquipo(LabManagerCliente.AdministradorEquipoService.View_Equipo newEquipo)
		{
            var resultado = cliente.AddEquipo(newEquipo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorEquipoService.DtoBase EditEquipo([System.ServiceModel.MessageParameterAttribute(Name="editEquipo")] LabManagerCliente.AdministradorEquipoService.View_Equipo editEquipo1)
		{
            var resultado = cliente.EditEquipo(editEquipo1);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorEquipoService.Lista_View_Historial_Equipo getHistorial(long EquipoId, System.DateTime FechaInicio, System.DateTime FechaFin)
		{
            var resultado = cliente.getHistorial(EquipoId,FechaInicio,FechaFin);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorEquipoService.DtoBool IsCodigoInventario(string codigo)
		{
            var resultado = cliente.IsCodigoInventario(codigo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class AdministradorEstudianteCliente{
        private static AdministradorEstudianteService.AdministradorEstudianteClient cliente =
            new AdministradorEstudianteService.AdministradorEstudianteClient();
        public static LabManagerCliente.AdministradorEstudianteService.Lista_View_Estudiantes getEstudiantes(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getEstudiantes(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorEstudianteService.DtoBase AddEstudiante(LabManagerCliente.AdministradorEstudianteService.View_Estudiante newEstudiante)
		{
            var resultado = cliente.AddEstudiante(newEstudiante);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorEstudianteService.DtoBase EditEstudiante([System.ServiceModel.MessageParameterAttribute(Name="editEstudiante")] LabManagerCliente.AdministradorEstudianteService.View_Estudiante editEstudiante1)
		{
            var resultado = cliente.EditEstudiante(editEstudiante1);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorEstudianteService.Lista_View_Facultad getFacultad(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getFacultad(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorEstudianteService.Lista_View_Historial_Estudiante getHistorialBasico(long UsuarioId, System.DateTime FechaInicio, System.DateTime FechaFin)
		{
            var resultado = cliente.getHistorialBasico(UsuarioId,FechaInicio,FechaFin);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class AdministradorFacultadCliente{
        private static AdministradorFacultadService.AdministradorFacultadClient cliente =
            new AdministradorFacultadService.AdministradorFacultadClient();
        public static LabManagerCliente.AdministradorFacultadService.Lista_View_Facultad getFacultad(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getFacultad(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorFacultadService.DtoBase AddFacultad(LabManagerCliente.AdministradorFacultadService.View_Facultad newFacultad)
		{
            var resultado = cliente.AddFacultad(newFacultad);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorFacultadService.DtoBase EditFacultad([System.ServiceModel.MessageParameterAttribute(Name="editFacultad")] LabManagerCliente.AdministradorFacultadService.View_Facultad editFacultad1)
		{
            var resultado = cliente.EditFacultad(editFacultad1);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class AdministradorMultaCliente{
        private static AdministradorMultaService.AdministradorMultaClient cliente =
            new AdministradorMultaService.AdministradorMultaClient();
        public static LabManagerCliente.AdministradorMultaService.Lista_View_Multas getMultas(long UsuarioId)
		{
            var resultado = cliente.getMultas(UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorMultaService.DtoBase AddMulta(LabManagerCliente.AdministradorMultaService.View_Multas newMulta)
		{
            var resultado = cliente.AddMulta(newMulta);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorMultaService.DtoBase EditMulta([System.ServiceModel.MessageParameterAttribute(Name="editMulta")] LabManagerCliente.AdministradorMultaService.View_Multas editMulta1)
		{
            var resultado = cliente.EditMulta(editMulta1);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorMultaService.Lista_View_EstadoMulta getEstadosMulta()
		{
            var resultado = cliente.getEstadosMulta();
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class AdministradorRestriccionCliente{
        private static AdministradorRestriccionService.AdministradorRestriccionClient cliente =
            new AdministradorRestriccionService.AdministradorRestriccionClient();
        public static LabManagerCliente.AdministradorRestriccionService.Lista_View_Restriccion getRestricciones(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getRestricciones(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorRestriccionService.DtoBase AddRestriccion(LabManagerCliente.AdministradorRestriccionService.View_Restriccion newRestriccion)
		{
            var resultado = cliente.AddRestriccion(newRestriccion);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorRestriccionService.DtoBase EditarRestriccion(LabManagerCliente.AdministradorRestriccionService.View_Restriccion editaRestriccion)
		{
            var resultado = cliente.EditarRestriccion(editaRestriccion);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class AdministradorSedeCliente{
        private static AdministradorSedeService.AdministradorSedeClient cliente =
            new AdministradorSedeService.AdministradorSedeClient();
        public static LabManagerCliente.AdministradorSedeService.Lista_View_Sede getSede(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getSede(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorSedeService.DtoBase AddSede(LabManagerCliente.AdministradorSedeService.View_Sede newSede)
		{
            var resultado = cliente.AddSede(newSede);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorSedeService.DtoBase EditSede([System.ServiceModel.MessageParameterAttribute(Name="editSede")] LabManagerCliente.AdministradorSedeService.View_Sede editSede1)
		{
            var resultado = cliente.EditSede(editSede1);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class AdministradorTipoEquipoCliente{
        private static AdministradorTipoEquipoService.AdministradorTipoEquipoClient cliente =
            new AdministradorTipoEquipoService.AdministradorTipoEquipoClient();
        public static LabManagerCliente.AdministradorTipoEquipoService.Lista_View_TiposEquipo getTiposEquipo(string FiltroTexto, System.Nullable<bool> Activo)
		{
            var resultado = cliente.getTiposEquipo(FiltroTexto,Activo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorTipoEquipoService.Lista_View_TipoEquipo_Activo getTipoEquiposActivos()
		{
            var resultado = cliente.getTipoEquiposActivos();
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorTipoEquipoService.DtoBase AddTipoEquipo(LabManagerCliente.AdministradorTipoEquipoService.View_TipoEquipo newTipoEquipo)
		{
            var resultado = cliente.AddTipoEquipo(newTipoEquipo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.AdministradorTipoEquipoService.DtoBase EditTipoEquipo([System.ServiceModel.MessageParameterAttribute(Name="editTipoEquipo")] LabManagerCliente.AdministradorTipoEquipoService.View_TipoEquipo editTipoEquipo1)
		{
            var resultado = cliente.EditTipoEquipo(editTipoEquipo1);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class CopiasDeSeguridadCliente{
        private static CopiasDeSeguridadService.CopiasDeSeguridadClient cliente =
            new CopiasDeSeguridadService.CopiasDeSeguridadClient();
        public static LabManagerCliente.CopiasDeSeguridadService.InformacionCopiasDeSeguridad getInformacionBackup(long UsuarioId)
		{
            var resultado = cliente.getInformacionBackup(UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.CopiasDeSeguridadService.DtoBase CreateBackup()
		{
            var resultado = cliente.CreateBackup();
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.CopiasDeSeguridadService.DtoBase RestoreBackup(string file, long UserId)
		{
            var resultado = cliente.RestoreBackup(file,UserId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class DetallePrestamoRecepcionCliente{
        private static DetallePrestamoRecepcionService.DetallePrestamoRecepcionClient cliente =
            new DetallePrestamoRecepcionService.DetallePrestamoRecepcionClient();
        public static LabManagerCliente.DetallePrestamoRecepcionService.Lista_View_DetallePrestamoRecepcion getDetallePrestamoRecepcion(System.DateTime FechaInicial, System.DateTime FechaFinal, System.Nullable<int> FacultadId)
		{
            var resultado = cliente.getDetallePrestamoRecepcion(FechaInicial,FechaFinal,FacultadId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class DeudoresCliente{
        private static DeudoresService.DeudoresClient cliente =
            new DeudoresService.DeudoresClient();
        public static LabManagerCliente.DeudoresService.Lista_View_Deudores getDeudores()
		{
            var resultado = cliente.getDeudores();
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class EstadisticasPrestamoEquiposCliente{
        private static EstadisticasPrestamoEquiposService.EstadisticasPrestamoEquiposClient cliente =
            new EstadisticasPrestamoEquiposService.EstadisticasPrestamoEquiposClient();
        public static LabManagerCliente.EstadisticasPrestamoEquiposService.Lista_View_EstadisticasPrestamoEquipos getEstadisticasPrestamoEquipos(System.Nullable<System.DateTime> FechaInicial, System.Nullable<System.DateTime> FechaFinal)
		{
            var resultado = cliente.getEstadisticasPrestamoEquipos(FechaInicial,FechaFinal);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class EstadoMultasCliente{
        private static EstadoMultasService.EstadoMultasClient cliente =
            new EstadoMultasService.EstadoMultasClient();
        public static LabManagerCliente.EstadoMultasService.Lista_View_EstadoMultas getEstadoMultas(System.Nullable<System.DateTime> FechaInicial, System.Nullable<System.DateTime> FechaFinal)
		{
            var resultado = cliente.getEstadoMultas(FechaInicial,FechaFinal);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class InactivarEstudianteCliente{
        private static InactivarEstudianteService.InactivarEstudianteClient cliente =
            new InactivarEstudianteService.InactivarEstudianteClient();
        public static LabManagerCliente.InactivarEstudianteService.Lista_View_Parametros getParametros(string FiltroTexto, int UsuarioId)
		{
            var resultado = cliente.getParametros(FiltroTexto,UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.InactivarEstudianteService.InformacionInactivar getInformacionInactivar()
		{
            var resultado = cliente.getInformacionInactivar();
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.InactivarEstudianteService.DtoBase InactivarEstudiantes(long UsuarioId)
		{
            var resultado = cliente.InactivarEstudiantes(UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.InactivarEstudianteService.DtoBase ActivarEstudiantes(long UsuarioId, long UsuarioIdActivar)
		{
            var resultado = cliente.ActivarEstudiantes(UsuarioId,UsuarioIdActivar);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.InactivarEstudianteService.DtoBool IsUserActive(string BarCode)
		{
            var resultado = cliente.IsUserActive(BarCode);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class MantenimientoCliente{
        private static MantenimientoService.MantenimientoClient cliente =
            new MantenimientoService.MantenimientoClient();
        public static LabManagerCliente.MantenimientoService.InformacionEliminarEstudiantesInactivos getInformacioneliminarEstudiantes(long UsuarioId)
		{
            var resultado = cliente.getInformacioneliminarEstudiantes(UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.MantenimientoService.DtoBase EliminarEstudiantesInactivos(long UsuarioId)
		{
            var resultado = cliente.EliminarEstudiantesInactivos(UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class PrestamoRecepcionCliente{
        private static PrestamoRecepcionService.PrestamoRecepcionClient cliente =
            new PrestamoRecepcionService.PrestamoRecepcionClient();
        public static LabManagerCliente.PrestamoRecepcionService.View_PrestamoRecepcion getInfoPrestamoRecepcion(string BarCode)
		{
            var resultado = cliente.getInfoPrestamoRecepcion(BarCode);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.PrestamoRecepcionService.RestriccionDto getRestriccionesEquipo(string barCodeEquipo)
		{
            var resultado = cliente.getRestriccionesEquipo(barCodeEquipo);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.PrestamoRecepcionService.View_EquiposACargo PrestarRecibirEquipo(int usuarioId, int auxiliarId, System.Nullable<int> FacultadId, System.Nullable<int> SemestreBasico, string barCodeEquipo, bool operacionManual)
		{
            var resultado = cliente.PrestarRecibirEquipo(usuarioId,auxiliarId,FacultadId,SemestreBasico,barCodeEquipo,operacionManual);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.PrestamoRecepcionService.DtoInt getTimeLogOut()
		{
            var resultado = cliente.getTimeLogOut();
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class SeguridadCliente{
        private static SeguridadService.SeguridadClient cliente =
            new SeguridadService.SeguridadClient();
        public static LabManagerCliente.SeguridadService.View_UsuarioAutentica Validar(string User, string Password)
		{
            var resultado = cliente.Validar(User,Password);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.SeguridadService.Lista_View_Menu MenuUsuario(long UsuarioId)
		{
            var resultado = cliente.MenuUsuario(UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.SeguridadService.Lista_View_Menu MenuReportesUsuario(long UsuarioId)
		{
            var resultado = cliente.MenuReportesUsuario(UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.SeguridadService.Lista_View_Menu MenuPrincipalUsuario(long UsuarioId)
		{
            var resultado = cliente.MenuPrincipalUsuario(UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
        public static LabManagerCliente.SeguridadService.Lista_View_Menu MenuGestionUsuario(long UsuarioId)
		{
            var resultado = cliente.MenuGestionUsuario(UsuarioId);
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
    public class VisorEquiposCliente{
        private static VisorEquiposService.VisorEquiposClient cliente =
            new VisorEquiposService.VisorEquiposClient();
        public static LabManagerCliente.VisorEquiposService.Lista_View_Equipo getEquiposPrestados()
		{
            var resultado = cliente.getEquiposPrestados();
            if (resultado.Error) throw new Exception(resultado.Mensaje);
            return resultado;
        }
    }
}