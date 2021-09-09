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

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public TransportePublico(int pasajeros, string nombre)
        {
            this.Pasajeros = pasajeros;
            this.Nombre = nombre;
        }

        public abstract string Avanzar();
        public abstract string Detenerse();

    }
}
