using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;


            Console.WriteLine("Introduce un numero del 1 al 7");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine(" Numero Ingresado: Uno");
                    break;

                case 2:
                    Console.WriteLine(" Numero Ingresado: Dos");
                    break;

                case 3:
                    Console.WriteLine(" Numero Ingresado: Tres");
                    break;

                case 4:
                    Console.WriteLine(" Numero Ingresado: Cuatro");
                    break;

                case 5:
                    Console.WriteLine(" Numero Ingresado: Cinco");
                    break;

                case 6:
                    Console.WriteLine(" Numero Ingresado: Seis");
                    break;

                case 7:
                    Console.WriteLine(" Numero Ingresado: Siete ");
                    break;

                default:
                    Console.WriteLine("Numero fuera de rango. Necesitas insertar un numero del 1 al 7");
                    break;

            }





        }
      }
   }
