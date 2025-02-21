using System;

class Program
{
    static void Main()
    {
        // Pedir los 4 números al usuario
        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el tercer número: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el cuarto número: ");
        double num4 = Convert.ToDouble(Console.ReadLine());

        // Colocar los números en una lista para facilitar el cálculo
        double[] numeros = { num1, num2, num3, num4 };

        // Calcular el promedio
        double promedio = (num1 + num2 + num3 + num4) / 4;

        // Calcular la desviación típica
        double sumaCuadrados = 0;
        foreach (var numero in numeros)
        {
            sumaCuadrados += Math.Pow(numero - promedio, 2);
        }
        double desviacionTipica = Math.Sqrt(sumaCuadrados / 4);

        // Mostrar el promedio y la desviación típica
        Console.WriteLine($"\nEl promedio de los números es: {promedio}");
        Console.WriteLine($"La desviación típica de los números es: {desviacionTipica:F3}");
    }
}
