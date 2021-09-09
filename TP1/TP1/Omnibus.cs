using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Omnibus : TransportePublico
    {

        public Omnibus(int pasajeros, string nombre) : base(pasajeros, nombre) { }

        public override string Avanzar()
        {
            return $"El Omnibus con {Pasajeros} pasajeros está avanzando.";
        }

        public override string Detenerse()
        {
            return $"El Omnibus con {Pasajeros} pasajeros se detuvo.";
        }
    }
}
