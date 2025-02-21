using System;

class Program
{
    static void Main()
    {
        // Solicitar los valores de las coordenadas (x1, y1) y (x2, y2)
        Console.Write("Ingresa el valor de x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el valor de y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el valor de x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el valor de y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calcular P usando la fórmula
        double P = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);

        // Mostrar el resultado
        Console.WriteLine($"\nEl valor de P es: {P}");
    }
}