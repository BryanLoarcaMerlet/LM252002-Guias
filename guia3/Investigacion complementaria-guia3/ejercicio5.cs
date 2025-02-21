using System;

class Program
{
    static void Main()
    {
        // Solicitar los datos de las preguntas realizadas y las contestadas correctamente
        Console.Write("Ingresa el total de preguntas realizadas: ");
        int totalPreguntas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa la cantidad de respuestas correctas: ");
        int respuestasCorrectas = Convert.ToInt32(Console.ReadLine());

        // Verificar que el total de preguntas no sea 0 para evitar división por cero
        if (totalPreguntas == 0)
        {
            Console.WriteLine("El total de preguntas no puede ser 0.");
            return;
        }

        // Calcular el porcentaje de respuestas correctas
        double porcentaje = (double)respuestasCorrectas / totalPreguntas * 100;

        // Determinar el nivel del postulante según el porcentaje
        string nivel;
        if (porcentaje >= 90)
        {
            nivel = "Nivel máximo";
        }
        else if (porcentaje >= 75)
        {
            nivel = "Nivel medio";
        }
        else if (porcentaje >= 50)
        {
            nivel = "Nivel regular";
        }
        else
        {
            nivel = "Fuera de nivel";
        }

        // Mostrar el resultado
        Console.WriteLine($"Porcentaje de respuestas correctas: {porcentaje:F2}%");
        Console.WriteLine($"Nivel: {nivel}");
    }
}
