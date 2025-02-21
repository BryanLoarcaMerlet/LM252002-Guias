using System;

class Program
{
    static void Main()
    {
        // Solicitar el radio y la altura del cilindro
        Console.Write("Ingresa el valor del radio (r) del cilindro: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el valor de la altura (h) del cilindro: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Calcular el área total usando la fórmula: AT = 2 * PI * r * (h + r)
        double areaTotal = 2 * Math.PI * radio * (altura + radio);

        // Mostrar el resultado
        Console.WriteLine($"\nEl área total del cilindro es: {areaTotal:F2}");
    }
}
