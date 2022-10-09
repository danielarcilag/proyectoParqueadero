using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParqueadero
{
    public class Patinetas:Vehiculo
    {
        private string _placa;
        private int _horaEntrada;
        private int _horaSalida;

        public Patinetas(string placa, int horaEntrada)
        {
            Placa = placa;
            HoraEntrada = horaEntrada;
        }

        public override string Placa { get => _placa; set => _placa = value; }
        public override int HoraEntrada { get => _horaEntrada; set => _horaEntrada = value; }
        public override int HoraSalida { get => _horaSalida; set => _horaSalida = value; }
    }
}
