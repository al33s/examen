using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class ClsTransacciones
    {
        public static string[] numerofactura = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", };

        public static int[] numeroplaca = new int[14];

        public static string[] fecha = new string[14];

        public static string[] hora = new string[14];

        public static string[] tipovehiculo = new string[] { "moto", "Liviano", "Pesado", "Autobus" };

        public static int[] caseta = new int[] { 1,2,3,4 };

        public static float[] montopago = new float[14];

        public static float[] pagocon = new float[14];

        public static float[] vuelto = new float[14];




        public static void vectores()
        {
            int[] numeros = new int[15];
            string[] cadenas = new string[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 0;               
            }

            for (int i = 0; i < cadenas.Length; i++)
            {
                cadenas[i] = "a";               
            }
        }

        public static void ingresar ()
        {
            char salir = 'n';
            byte i = 0;

            do
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("         REGISTRAR FLUJO VEHICULAR         ");
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine();

                Console.WriteLine(" Numero Factura: " + numerofactura[i]);
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(" (ESTE ES SU NUMERO DE REGISTRO PORFAVOR NO PERDER)");
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine();
                

                Console.WriteLine(" Numero Placa: ");
                numeroplaca[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                

                Console.WriteLine(" fecha: ");
                fecha[i] = Console.ReadLine();
                Console.WriteLine();
                
                Console.WriteLine(" Hora: ");
                hora[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(" Tipo de vehiculo: ");
                Console.WriteLine(" [ 0= Moto    1= Liviano     2= Pesado     3= Autobús ]");
                tipovehiculo[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(" Numero caseta: ");
                Console.WriteLine("[ 0= caseta 1     1= caseta 2     2= caseta 3 ]");
                caseta[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine("Tabla de precios");
                Console.WriteLine();
                Console.WriteLine(" Vehiculo liviano  ¢ 700");
                Console.WriteLine(" Pesado            ¢ 2700");
                Console.WriteLine(" Moto              ¢ 500");
                Console.WriteLine(" Autobus           ¢ 3700");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                Console.WriteLine(" Monto a pagar:");
                montopago[i] = float.Parse(Console.ReadLine());
                Console.WriteLine();


                Console.WriteLine(" Paga con: ");
                pagocon[i] = float.Parse(Console.ReadLine());
                Console.WriteLine();

                vuelto[i] = pagocon[i] - montopago[i];
                Console.WriteLine(" Vuelto: " + vuelto[i]);               
                Console.WriteLine();

                i++;

                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("         Desea continuar s/n         ");
                Console.ForegroundColor= ConsoleColor.White;
                salir = Convert.ToChar(Console.ReadLine().ToLower());
                Console.Clear();

            } while (salir != 'n');
        }

        public static void consultar()
        {
            char salir2 = 'n';

            Console.WriteLine("Digite su numero de factura: ");
            string buscarfactura = Console.ReadLine();

            for (int i = 0; i < numerofactura.Length; i++)
            {
                if (numerofactura[i].Equals(buscarfactura, StringComparison.OrdinalIgnoreCase))
                {
                    do
                    {
                        Console.WriteLine("numero de placa: " + numeroplaca[i]);
                        Console.WriteLine();
                        Console.WriteLine("fecha: " + fecha[i]);
                        Console.WriteLine();
                        Console.WriteLine("Hora: " + hora[i]);
                        Console.WriteLine();
                        Console.WriteLine("Tipo de vehiculo: " + tipovehiculo[i]);
                        Console.WriteLine();
                        Console.WriteLine("numero caseta: " + caseta[i]);
                        Console.WriteLine();
                        Console.WriteLine("monto a pagar: " + montopago[i]);
                        Console.WriteLine();
                        Console.WriteLine("pago con: " + pagocon[i]);
                        Console.WriteLine();
                        Console.WriteLine("vuelto: " + vuelto[i]);
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("desea salir: s/n");
                        salir2 = Convert.ToChar(Console.ReadLine().ToLower());
                        Console.ForegroundColor= ConsoleColor.White;
                        Console.Clear();

                    } while (salir2 != 's');
                }
            }
        }

        public static void modificar()
        {
            char salir3 = 'n';

            Console.WriteLine("Digite su numero de factura: ");
            string buscarfactura = Console.ReadLine();

            for (int i = 0; i < numerofactura.Length; i++)
            {
                if (numerofactura[i].Equals(buscarfactura, StringComparison.OrdinalIgnoreCase))
                {
                    do
                    {
                        Console.WriteLine(" el numero de placa: "+numeroplaca[i]+ " lo desea cambiar por:");
                        numeroplaca[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine(" la fecha: "+fecha[i]+" lo desea cambiar por: ");
                        fecha[i] = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine(" La Hora: "+hora[i]+" la desea cambiar por: ");
                        hora[i] = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine(" El Tipo de vehiculo: " + tipovehiculo[i]+ " lo desea  cambiar por: [ 0= Moto    1= Liviano     2= Pesado     3= Autobús ]");
                        tipovehiculo[i] = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine(" El numero de caseta: " + caseta[i]+ " lo desea cambiar por: [ 0= caseta 1     1= caseta 2     2= caseta 3 ] ");
                        caseta[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Tabla de precios");
                        Console.WriteLine();
                        Console.WriteLine(" Vehiculo liviano  ¢ 700");
                        Console.WriteLine(" Pesado            ¢ 2700");
                        Console.WriteLine(" Moto              ¢ 500");
                        Console.WriteLine(" Autobus           ¢ 3700");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine(" el monto a pagar: " + montopago[i]+ "lo desea cambiar por: ");
                        montopago[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine(" pago con: " + pagocon[i]+" y lo desea ahora pagar con: ");
                        pagocon[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine();

                        vuelto[i] = pagocon[i] - montopago[i];
                        Console.WriteLine(" su nuevo vuelto es de: "+ vuelto[i]);
                        Console.WriteLine();


                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("desea salir: s/n");
                        salir3 = Convert.ToChar(Console.ReadLine().ToLower());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();

                    } while (salir3 != 's');
                }
            }
        }

        public static void reporte()
        {

            char salir4 = 'n';

            Console.WriteLine("Digite su numero de factura: ");
            string buscarfactura = Console.ReadLine();

            for (int i = 0; i < numerofactura.Length; i++)
            {
                if (numerofactura[i].Equals(buscarfactura, StringComparison.OrdinalIgnoreCase))
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("                           Titulo del Reporte         ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("N factura     placa      tipo de vehiculo     caseta     montopagar      pagar con     vuelto");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("==================================================================================================");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("     "+numerofactura[i] + "      " + numeroplaca[i] + "                   " + tipovehiculo[i] + "               " + caseta[i] + "              " + montopago[i] + "            " + pagocon[i]+"          " + vuelto[i]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("==================================================================================================");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("cantidad de vehiculos "+i+"            total      " + montopago[i]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("==================================================================================================");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();



                        Console.WriteLine("<<<Pulse s para regresar >>>");
                        salir4 = Convert.ToChar(Console.ReadLine().ToLower());


                    } while (salir4 != 's');
                }

            }
                
        }
    }
}
