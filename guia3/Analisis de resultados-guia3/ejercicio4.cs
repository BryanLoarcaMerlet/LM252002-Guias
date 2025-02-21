using System;

class Program
{
    static void Main()
    {
        // Solicitar los tres números
        Console.Write("Ingresa el primer número: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el tercer número: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Determinar el menor número
        int menor = a;

        if (b < menor)
        {
            menor = b;
        }

        if (c < menor)
        {
            menor = c;
        }

        // Mostrar el resultado
        Console.WriteLine($"El número menor es: {menor}");
    }
}
