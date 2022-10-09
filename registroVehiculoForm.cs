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
    public partial class registroVehiculoForm : Form
    {

        private Carros[] _arrayCarros = new Carros[10];
        private Motos[] _arrayMotos = new Motos[10];
        private Patinetas[] _arrayPatinetas = new Patinetas[10];
        public registroVehiculoForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (tipoVehiculoComboBox.Text == "CARRO")
            {
                Console.WriteLine(_arrayCarros[0]);
                if (_arrayCarros[0] != null)
                    aviso.Text = "No hay cupos para carro";
                else
                {
                    _arrayCarros.Append(new Carros(placaText.Text, Convert.ToInt32(horaEntradaTxt.Text)));
                    aviso.Text = "Registrado";
                }
            }

            else if (tipoVehiculoComboBox.Text == "MOTO")
            {
                Console.WriteLine(_arrayMotos.Length);
                if (_arrayMotos[9] != null)
                    aviso.Text = "No hay cupos para moto";
                else
                {
                    _arrayMotos.Append(new Motos(placaText.Text, Convert.ToInt32(horaEntradaTxt.Text)));
                    aviso.Text = "Registrado";
                }

            }
            else if (tipoVehiculoComboBox.Text == "PATINETA")
            {
                if (_arrayPatinetas[9] != null)
                    aviso.Text = "No hay cupos para patineta";
                else
                {
                    _arrayPatinetas.Append(new Patinetas(placaText.Text, Convert.ToInt32(horaEntradaTxt.Text)));
                    aviso.Text = "Registrado";
                }
            }

            tipoVehiculoComboBox.ResetText();
            placaText.Clear();
            horaEntradaTxt.Clear();

        }
    }
}
