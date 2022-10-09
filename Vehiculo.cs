using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParqueadero
{
    abstract public class Vehiculo
    {
        public abstract string Placa { get; set; }
        public abstract int HoraEntrada { get; set; }
        public abstract int HoraSalida { get; set; }
    }
}
