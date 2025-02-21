using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool opcionValida = false; // Flag para controlar si la opción es válida

            while (!opcionValida) // Repite mientras la opción no sea válida
            {
                // Mostrar el menú al usuario y pedirle que escoja una opción
                Console.WriteLine("Escoje una opcion de usuario para ver su informacion");
                Console.WriteLine("i)  Ismaeel");
                Console.WriteLine("c)  Cecilia");
                Console.WriteLine("s)  Samuel");
                Console.WriteLine("m)  Manuel");
                Console.WriteLine("\nEscoje una opcion (i, c, s, m):");
               
                char opcion = char.Parse(Console.ReadLine().ToLower()); // Convertir a minúscula para manejar una sola comparación

                switch (opcion)
                {
                    case 'i':
                        Console.WriteLine("Nombre: Ismael Sandoval");
                        Console.WriteLine("Edad: 55 años");
                        Console.WriteLine("Sexo: Masculino");
                        Console.WriteLine("Trabajo: Ingeniero de software");
                        Console.WriteLine("Carrera: Ingenieria electronico");
                        Console.WriteLine("Deporte: Basketball");
                        Console.WriteLine("Artes y entretenimiento: Tocar la guitarra");
                        opcionValida = true; // Marca la opción como válida
                        break;

                    case 'c':
                        Console.WriteLine("Nombre: Cecilia Ortiz");
                        Console.WriteLine("Edad: 35 años");
                        Console.WriteLine("Sexo: Femenino");
                        Console.WriteLine("Trabajo: Maestra de matematicas");
                        Console.WriteLine("Carrera: Profesorado en el área de números");
                        Console.WriteLine("Deporte: Tejer y yoga");
                        Console.WriteLine("Artes y entretenimiento: Tocar la trompeta");
                        opcionValida = true; // Marca la opción como válida
                        break;

                    case 's':
                        Console.WriteLine("Nombre: Samuel Matus");
                        Console.WriteLine("Edad: 41 años");
                        Console.WriteLine("Sexo: Masculino");
                        Console.WriteLine("Trabajo: Ingeniero de software");
                        Console.WriteLine("Carrera: Ingeniería en Ciencias de las Computación");
                        Console.WriteLine("Deporte: Futbol");
                        Console.WriteLine("Artes y entretenimiento: Jugar Ajedrez");
                        opcionValida = true; // Marca la opción como válida
                        break;

                    case 'm':
                        Console.WriteLine("Nombre: Manuel Gutierrez");
                        Console.WriteLine("Edad: 28 años");
                        Console.WriteLine("Sexo: Masculino");
                        Console.WriteLine("Trabajo: Arquitecto en software");
                        Console.WriteLine("Carrera: Ingeniería en arquitectura de software");
                        Console.WriteLine("Deporte: Futbol, basketball y beisball");
                        Console.WriteLine("Artes y entretenimiento: Tocar el piano");
                        opcionValida = true; // Marca la opción como válida
                        break;

                    default:
                        Console.WriteLine("La opción escogida no es válida, por favor ingrese una opción válida.");
                        break;
                }
            }
        }
    }
}