using System;

class Program
{
    static void Main()
    {
        // Solicitar las aportaciones de Juan, Raquel y Daniel
        Console.Write("Ingresa el aporte de Juan en dólares: ");
        double aporteJuan = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el aporte de Raquel en dólares: ");
        double aporteRaquel = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el aporte de Daniel en soles: ");
        double aporteDanielSoles = Convert.ToDouble(Console.ReadLine());

        // Convertir el aporte de Daniel de soles a dólares
        double aporteDanielDolares = aporteDanielSoles / 3.25;

        // Calcular el capital total en dólares
        double capitalTotal = aporteJuan + aporteRaquel + aporteDanielDolares;

        // Calcular el porcentaje que aporta cada uno
        double porcentajeJuan = (aporteJuan / capitalTotal) * 100;
        double porcentajeRaquel = (aporteRaquel / capitalTotal) * 100;
        double porcentajeDaniel = (aporteDanielDolares / capitalTotal) * 100;

        // Mostrar los resultados
        Console.WriteLine("\nCapital total en dólares: " + capitalTotal);
        Console.WriteLine($"Juan aporta un {porcentajeJuan:F2}% del capital total.");
        Console.WriteLine($"Raquel aporta un {porcentajeRaquel:F2}% del capital total.");
        Console.WriteLine($"Daniel aporta un {porcentajeDaniel:F2}% del capital total.");
    }
}
