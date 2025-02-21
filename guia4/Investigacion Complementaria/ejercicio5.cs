using System;

class Program
{
    static void Main()
    {
        // Pedir al usuario que ingrese un número entre 1 y 9
        Console.WriteLine("Ingrese un número entero entre 1 y 9:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Verificar que el número esté en el rango de 1 a 9
        if (numero >= 1 && numero <= 9)
        {
            // Mostrar el número en forma ordinal
            string ordinal = ObtenerOrdinal(numero);
            Console.WriteLine($"El número {numero} en forma ordinal es: {ordinal}");
        }
        else
        {
            Console.WriteLine("Número fuera de rango. Solo se aceptan números entre 1 y 9.");
        }
    }

    // Método para obtener el número ordinal
    static string ObtenerOrdinal(int numero)
    {
        switch (numero)
        {
            case 1: return "primero";
            case 2: return "segundo";
            case 3: return "tercero";
            case 4: return "cuarto";
            case 5: return "quinto";
            case 6: return "sexto";
            case 7: return "séptimo";
            case 8: return "octavo";
            case 9: return "noveno";
            default: return "";
        }
    }
}
