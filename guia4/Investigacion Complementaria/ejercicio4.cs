using System;

class Program
{
    static void Main()
    {
        // Crear un diccionario con los números romanos y sus valores
        var numerosRomanos = new Dictionary<string, int>
        {
            { "I", 1 },
            { "II", 2 },
            { "III", 3 },
            { "IV", 4 },
            { "V", 5 },
            { "VI", 6 },
            { "VII", 7 },
            { "VIII", 8 },
            { "IX", 9 },
            { "X", 10 },
            { "XI", 11 },
            { "XII", 12 },
            { "XIII", 13 },
            { "XIV", 14 },
            { "XV", 15 },
            { "XVI", 16 },
            { "XVII", 17 },
            { "XVIII", 18 },
            { "XIX", 19 },
            { "XX", 20 }
        };

        // Pedir al usuario que ingrese un número romano
        Console.WriteLine("Ingrese un número romano entre I y XX:");
        string numeroRomano = Console.ReadLine().ToUpper();  // Convertir a mayúsculas para mayor consistencia

        // Verificar si el número romano ingresado es válido
        if (numerosRomanos.ContainsKey(numeroRomano))
        {
            int valor = numerosRomanos[numeroRomano];
            Console.WriteLine($"El valor en número entero de {numeroRomano} es: {valor}");
        }
        else
        {
            Console.WriteLine("Número romano inválido o fuera de rango.");
        }
    }
}
