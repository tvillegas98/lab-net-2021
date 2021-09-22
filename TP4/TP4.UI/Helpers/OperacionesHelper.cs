using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Logic;
using TP4.UI.Helpers;

namespace TP4.UI.Helpers
{
    public static class OperacionesHelper
    {
        const string menuABM = "1.Agregar un terriotrio\n2.Modificar un territorio\n3.Eliminar un territorio.\n4.Cerrar ABM\nIngrese una opción: ";
        const string opcionInvalida = "Opción inválida, intente nuevamente ";
        const string numeroInvalido = "Número no válido, intente nuevamente";
        const string inputRegionID = "Ingrese el ID de una región existente";
        const int minOpciones = 1;
        const int maxOpciones = 4;
        public static void RealizarOperacionMenuABM(int opcion, TerritoriesLogic territorios)
        {
            if (opcion == 1)
            {
                TerritoriesHelper.AgregarTerritorio(territorios);
            } else if (opcion == 2)
            {
                TerritoriesHelper.ActualizarTerritorio(territorios);
            }
            else
            {
                TerritoriesHelper.EliminarTerritorio(territorios);
            }
        }

        public static void abrirMenuABM()
        {
            bool cerrarMenu = false;
            TerritoriesLogic territorios = new TerritoriesLogic();
            while (!cerrarMenu)
            {
                Console.Clear();
                int opcion = InputHelpers.ObtenerNumero(menuABM, opcionInvalida, minOpciones, maxOpciones);
                if (opcion == maxOpciones) cerrarMenu = true;
                else
                {
                    RealizarOperacionMenuABM(opcion, territorios);
                }
            }
        }

        public static void RealizarOperacionMenu(int opcion)
        {
            Console.Clear();
            if (opcion == 1)
            {
                OutputHelpers.MostrarTerritorios();
            } else if (opcion == 2)
            {
                OutputHelpers.MostrarEmpleados();
            } else if (opcion == 3)
            {
                OutputHelpers.MostrarRegiones();
            }
            else
            {
                abrirMenuABM();
            }
        }

    }
}

