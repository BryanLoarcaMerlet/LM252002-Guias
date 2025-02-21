using System;

class Program
{
    static void Main()
    {
        // Solicitar los valores de los semi-ejes a y b
        Console.Write("Ingresa el valor del semi-eje mayor (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el valor del semi-eje menor (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Calcular el perímetro utilizando la fórmula de Ramanujan
        double parte1 = 3 * (a + b);
        double parte2 = Math.Sqrt((3 * a + b) * (a + 3 * b));
        double perimetro = Math.PI * (parte1 - parte2);

        // Mostrar el resultado
        Console.WriteLine($"\nEl perímetro aproximado de la elipse es: {perimetro:F3}");
    }
}
