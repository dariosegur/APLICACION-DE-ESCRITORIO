using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManagerCliente.SeguridadService;

namespace LabManager.Seguridad
{
    class CacheUsuarios
    {
        private class View_UsuarioAutentica_Cache
        {
            public long UsuarioId { get; set; }
            public string Documento { get; set; }
            public string Password { get; set; }
        }
        private const int cahceSize=2;
        private static View_UsuarioAutentica_Cache[] ultimosUsuarios;
        public CacheUsuarios()
        {
            if (ultimosUsuarios == null)
            {
                ultimosUsuarios = new View_UsuarioAutentica_Cache[cahceSize];
                for (int i = 0; i < ultimosUsuarios.Length; i++)
                {
                    ultimosUsuarios[i] = new View_UsuarioAutentica_Cache();
                }
            }
        }

        public void Add(View_UsuarioAutentica usuario,string password)
        {
            var usuarioYaAutenticado = ultimosUsuarios.Any(u=>u.UsuarioId==usuario.UsuarioId);
            if (usuarioYaAutenticado) return;
            for (int i = ultimosUsuarios.Length-1; i >0 ; i--)
            {
                ultimosUsuarios[i] = ultimosUsuarios[i-1];
            }
            ultimosUsuarios[0] = new View_UsuarioAutentica_Cache {
                Documento =usuario.Documento,
                Password=password,
                UsuarioId=usuario.UsuarioId
            };
        }

        public string getLastPassword(string Documento)
        {
            var usuarioYaAutenticado = ultimosUsuarios.Where(u => u.Documento == Documento).ToList();
            if (usuarioYaAutenticado.Count() <= 0) return null;
            return usuarioYaAutenticado[0].Password;
        }

        public bool Exist(string barcode) {
            try
            {
                return ultimosUsuarios.Any(u=>u.Documento==barcode);
            }
            catch
            {
                return false;
            }
        }
    }
}
