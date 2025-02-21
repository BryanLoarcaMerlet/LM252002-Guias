using System;

class Program
{
    static void Main()
    {
        // Pedir al usuario que ingrese la cantidad en kilómetros
        Console.Write("Ingresa la cantidad en kilómetros: ");
        double km = Convert.ToDouble(Console.ReadLine());

        // Convertir kilómetros a metros
        double metros = km * 1000;

        // Convertir metros a yardas (1 metro = 1.09361 yardas)
        double yardas = metros * 1.09361;

        // Convertir metros a varas (1 metro = 1.1963 varas)
        double varas = metros * 1.1963;

        // Mostrar los resultados
        Console.WriteLine("\nResultados de la conversión:");
        Console.WriteLine($"{km} kilómetros son equivalentes a:");
        Console.WriteLine($"{metros} metros");
        Console.WriteLine($"{yardas} yardas");
        Console.WriteLine($"{varas} varas");
    }
}
