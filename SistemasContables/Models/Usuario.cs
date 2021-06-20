using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.Models
{
    public class Usuario
    {
        private int idUsuario { get; set; }
        private string nombreUsuario { get; set; }
        private string rol { get; set; }
        private string password { get; set; }

        public int IdUsuario
        {
            get
            {
                return this.idUsuario;
            }

            set
            {
                this.idUsuario = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return this.nombreUsuario;
            }
            set
            {
                this.nombreUsuario = value;
            }
        }

        public string Rol
        {
            get
            {
                return this.rol;
            }
            set
            {
                this.rol = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

    }
}
