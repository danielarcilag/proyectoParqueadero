using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParqueadero
{
    public partial class RegistroForm : Form
    {
        private usuarioUsual[] _usuariosUsuales = new usuarioUsual[5];
        private bool _error = false; 

        public RegistroForm()
        {
            InitializeComponent();
        }

        public RegistroForm(usuarioUsual[] usuariosUsuales)
        {
            InitializeComponent();
            UsuariosUsuales = usuariosUsuales;
        }

        public usuarioUsual[] UsuariosUsuales { get => _usuariosUsuales; set => _usuariosUsuales = value; }

        private void registrobtn_Click(object sender, EventArgs e)
        {
            _error = false;
            foreach (usuarioUsual usuario in UsuariosUsuales)
            {
                if(nombreUsuarioTxt.Text == usuario.NombreUsuario)
                {
                    labelError.Text = "El nombre de usuario ya existe";
                    _error = true;
                    break;
                }
            }

            if (nombreUsuarioTxt.Text=="" || contraseniaTxt.Text == "")
            {
                labelError.Text = "el nombre de usuario o la contraseña no pueden ser vacios";
                _error = true;
            }     
            
            
            if(!_error)
            {
                Form1 loginForm = new Form1(new usuarioOcasional(nombreUsuarioTxt.Text, contraseniaTxt.Text));
                Hide();
                loginForm.Show();
            }

        }
    }
}
