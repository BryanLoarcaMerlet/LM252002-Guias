using System;

class Program
{
    static void Main()
    {
        // Leer las tres longitudes de los lados del triángulo
        Console.WriteLine("Ingresa las tres longitudes de los lados del triángulo:");

        Console.Write("Lado 1: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado 3: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Verificar si los lados pueden formar un triángulo
        if (EsTriangulo(lado1, lado2, lado3))
        {
            // Determinar el tipo de triángulo
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Las longitudes no forman un triángulo.");
        }
    }

    // Método para verificar si tres lados pueden formar un triángulo
    static bool EsTriangulo(double lado1, double lado2, double lado3)
    {
        // El lado mayor debe ser menor que la suma de los otros dos
        return (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1);
    }
}
