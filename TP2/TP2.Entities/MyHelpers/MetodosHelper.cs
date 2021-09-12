using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Entities.MyHelpers
{
    public static class MetodosHelper
    {
        public static int ObtenerNumero(string mensajeEntrada, string mensajeError, 
            int topeInferior = int.MinValue, int topeSuperior = int.MaxValue)
        {
            int numero;

            Console.WriteLine(mensajeEntrada);
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out numero) || numero < topeInferior || numero > topeSuperior)
            {
                Console.WriteLine(mensajeError);
                entrada = Console.ReadLine();
            }

            return numero;
        }
    }
}
