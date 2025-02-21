using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un número
        Console.Write("Ingresa un número entero positivo de hasta tres cifras: ");
        string input = Console.ReadLine();

        // Verificar si el valor ingresado es un número entero
        if (int.TryParse(input, out int numero) && numero > 0)
        {
            // Comprobar el número de cifras
            if (numero < 10)
            {
                Console.WriteLine("El número tiene 1 cifra.");
            }
            else if (numero < 100)
            {
                Console.WriteLine("El número tiene 2 cifras.");
            }
            else if (numero < 1000)
            {
                Console.WriteLine("El número tiene 3 cifras.");
            }
            else
            {
                Console.WriteLine("Error: El número tiene más de 3 cifras.");
            }
        }
        else
        {
            Console.WriteLine("Error: Por favor, ingresa un número entero positivo.");
        }
    }
}
