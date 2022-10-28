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
    public partial class menuForm : Form
    {
        private Usuario _usuarioLogueado;
        public menuForm(Usuario usuarioLogueado)
        {
            InitializeComponent();
            _usuarioLogueado = usuarioLogueado;
            tituloTxt.Text = "Bienvenido "+ usuarioLogueado.NombreUsuario;
            if (usuarioLogueado.TIPOUSUARIO == "USUAL")
            {
                ocasionalToUsualBtn.Enabled = false;
                ocasionalToUsualBtn.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registroVehiculoForm registrarVehiculoForm = new registroVehiculoForm();
            Hide();
            registrarVehiculoForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ocasionalToUsualBtn_Click(object sender, EventArgs e)
        {
            _usuarioLogueado = new usuarioUsual(_usuarioLogueado.NombreUsuario, _usuarioLogueado.Contrasenia);
        }
    }
}
