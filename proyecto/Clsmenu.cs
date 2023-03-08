using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class Clsmenu
    {


        public static void menu()
        {
            int opcion;

            do
            {
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine("       BIENVENIDO");
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine(" 1- Inicializar Vectores");
                Console.WriteLine();
                Console.WriteLine(" 2- Ingresar Paso Vehicular");
                Console.WriteLine();
                Console.WriteLine(" 3- Consulta de Vehiculos xNumero de Placa");
                Console.WriteLine();
                Console.WriteLine(" 4- Modificar Datos Vehiculos x numero de placa");
                Console.WriteLine();
                Console.WriteLine(" 5- Reporte todos los datos de los vectores");
                Console.WriteLine();
                Console.WriteLine(" 6- salir");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(" digite una opcion");
                Console.ForegroundColor = ConsoleColor.White;
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        ClsTransacciones.vectores();
                        break;
                    case 2:
                        Console.Clear();
                        ClsTransacciones.ingresar();
                        break;
                    case 3:
                        Console.Clear();
                        ClsTransacciones.consultar();
                        break;
                    case 4:
                        Console.Clear();
                        ClsTransacciones.modificar();
                        break;
                    case 5:
                        Console.Clear();
                        ClsTransacciones.reporte();
                        break;
                        
                    default:
                        break;
                }


            } while (opcion != 6);











        }
    }
}
