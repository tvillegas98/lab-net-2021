using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Logic;
using TP4.UI.Helpers;
namespace TP4.UI
{
    class Program
    {
        const string menu = "1. Mostrar Territorios\n2. Mostrar Empleados\n3. Mostrar Regiones\n4. ABM de un Territorio.\n5. Cerrar Programa\nIngrese una opciön: ";
        const string opcionInvalida = "Opción incorrecta, intente nuevamente";
        const int minOpciones = 1;
        const int maxOpciones = 5;
        static void Main(string[] args)
        {
            bool cerrarMenu = false;
            while (!cerrarMenu)
            {
                Console.Clear();
                int opcion = InputHelpers.ObtenerNumero(menu, opcionInvalida, minOpciones, maxOpciones);
                if (opcion == maxOpciones) cerrarMenu = true;
                else
                {
                    OperacionesHelper.RealizarOperacionMenu(opcion);
                }
            }
        }
    }
}
