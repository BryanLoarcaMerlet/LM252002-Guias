using System;

class Program
{
    static void Main()
    {
        // Velocidades del tren en cada segmento del trayecto
        double v1 = 120;  // Velocidad en km/h para el primer tramo
        double v2 = 20;   // Velocidad en km/h para el segundo tramo
        double v3 = 100;  // Velocidad en km/h para el tercer tramo
        double v4 = 130;  // Velocidad en km/h para el cuarto tramo

        // Número de elementos (en este caso son 4 velocidades)
        int n = 4;

        // Calcular la media armónica
        double sumaReciprocales = (1 / v1) + (1 / v2) + (1 / v3) + (1 / v4);
        double mediaArmonica = n / sumaReciprocales;

        // Mostrar el resultado
        Console.WriteLine($"La media armónica de las velocidades es: {mediaArmonica:F2} km/h");
    }
}
