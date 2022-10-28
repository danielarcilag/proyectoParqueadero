using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParqueadero
{
    public class usuarioOcasional : Usuario
    {
        string _nombreUsuario = "_";
        string _contrasenia = "_";
        const string _TIPOUSUARIO = "OCASIONAL";

        public usuarioOcasional(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }

        public usuarioOcasional()
        {
        }

        public override string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public override string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public override string TIPOUSUARIO => _TIPOUSUARIO;
    }
}
