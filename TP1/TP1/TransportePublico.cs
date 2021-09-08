using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public abstract class TransportePublico
    {
        private int _pasajeros;

        public int Pasajeros
        {
            get { return _pasajeros; }
            set { _pasajeros = value; }
        }

        public TransportePublico(int pasajeros)
        {
            this.Pasajeros = pasajeros;
        }

        public abstract string Avanzar();
        public abstract string Detenerse();

    }
}
