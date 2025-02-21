using System;

class Program
{
    static void Main()
    {
        // Solicitar el valor del lado del triángulo equilátero
        Console.Write("Ingresa el valor del lado del triángulo equilátero: ");
        double lado = Convert.ToDouble(Console.ReadLine());

        // Calcular el área del triángulo equilátero
        double area = (Math.Sqrt(3) / 4) * Math.Pow(lado, 2);

        // Mostrar el área
        Console.WriteLine($"\nEl área del triángulo equilátero con lado {lado} es: {area:F2}");
    }
}
