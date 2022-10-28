using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private usuarioUsual[] _usuariosUsuales = new usuarioUsual[5];
        private usuarioOcasional _usuarioOcasional = new usuarioOcasional();
        
        public Form1()
        {
            InitializeComponent();
            UsuariosUsuales[0] = new usuarioUsual("asd", "asd");
            UsuariosUsuales[1] = new usuarioUsual("santiago", "321");
            UsuariosUsuales[2] = new usuarioUsual("ramiro", "123");
            UsuariosUsuales[3] = new usuarioUsual("", "");
            UsuariosUsuales[4] = new usuarioUsual("", "");
        }
        public Form1(usuarioOcasional usuarioOcasional)
        {
            InitializeComponent();
            UsuarioOcasional = usuarioOcasional;
            UsuariosUsuales[0] = new usuarioUsual("asd", "asd");
            UsuariosUsuales[1] = new usuarioUsual("santiago", "321");
            UsuariosUsuales[2] = new usuarioUsual("ramiro", "123");
            UsuariosUsuales[3] = new usuarioUsual("", "");
            UsuariosUsuales[4] = new usuarioUsual("", "");

        }

        public usuarioOcasional UsuarioOcasional { get => _usuarioOcasional; set => _usuarioOcasional = value; }
        public usuarioUsual[] UsuariosUsuales { get => _usuariosUsuales; set => _usuariosUsuales = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (usuarioUsual usuario in UsuariosUsuales)
            {
                if (usuario.NombreUsuario == nombreUsuarioTxt.Text && usuario.Contrasenia == contraseniaTxt.Text)
                {
                    menuForm menuForm = new menuForm(usuario);
                    Hide();
                    menuForm.Show();
                    break;
                }
            }

            if (UsuarioOcasional.NombreUsuario == nombreUsuarioTxt.Text && UsuarioOcasional.Contrasenia == contraseniaTxt.Text)
            {
                menuForm menuForm = new menuForm(UsuarioOcasional);
                Hide();
                menuForm.Show();
            }

            labelLogin.Text = "Nombre de usuario o contraseña incorrectos";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroForm registroForm = new RegistroForm(UsuariosUsuales);
            Hide();
            registroForm.Show();
        }
    }
}
