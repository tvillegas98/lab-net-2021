using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Taxi : TransportePublico
    {

        public Taxi(int pasajeros) : base(pasajeros) { }

        public override string Avanzar()
        {
            return $"El Taxi con {Pasajeros} pasajeros está avanzando";
        }

        public override string Detenerse()
        {
            return $"El Taxi con {Pasajeros} pasajeros se detuvo";
        }
    }
}
