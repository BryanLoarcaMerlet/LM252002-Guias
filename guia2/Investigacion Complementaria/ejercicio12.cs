using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario las calificaciones para cada componente
        Console.Write("Ingresa la calificación de los exámenes sorpresa (promedio de ambos): ");
        double examenesSorpresa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la calificación de los exámenes cortos (promedio de ambos): ");
        double examenesCortos = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la calificación de la tarea1, trabajo1 y participación en clase: ");
        double tareaTrabajoParticipacion = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la calificación del proyecto: ");
        double proyecto = Convert.ToDouble(Console.ReadLine());

        // Calcular la calificación final utilizando los porcentajes correspondientes
        double calificacionFinal = (0.40 * examenesSorpresa) + (0.30 * examenesCortos) + (0.20 * tareaTrabajoParticipacion) + (0.10 * proyecto);

        // Mostrar el resultado
        Console.WriteLine($"\nLa calificación final del alumno es: {calificacionFinal:F2}");
    }
}
