using System;

class Program
{
    static void Main()
    {
        // Solicitar las cuatro calificaciones al usuario
        Console.WriteLine("Ingresa las 4 calificaciones de las prácticas:");
        double[] calificaciones = new double[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Calificación {i + 1}: ");
            calificaciones[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Ordenar las calificaciones de menor a mayor
        Array.Sort(calificaciones);

        // La calificación eliminada es la menor
        double calificacionEliminada = calificaciones[0];

        // Calcular el promedio de las tres calificaciones más altas
        double promedio = (calificaciones[1] + calificaciones[2] + calificaciones[3]) / 3;

        // Mostrar los resultados
        Console.WriteLine($"\nLa calificación eliminada es: {calificacionEliminada}");
        Console.WriteLine($"El promedio de las tres calificaciones más altas es: {promedio:F2}");
    }
}
