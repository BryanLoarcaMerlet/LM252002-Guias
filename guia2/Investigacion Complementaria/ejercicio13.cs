using System;

class Program
{
    static void Main()
    {
        // Declarar variables
        int NUM, NUMINV, U, D, C, AUX;

        // Solicitar el número de 3 cifras
        Console.Write("Ingresa un número entero de 3 cifras: ");
        NUM = Convert.ToInt32(Console.ReadLine());

        // Guardar el número original para mostrarlo después
        AUX = NUM;

        // Calcular centenas (C), decenas (D) y unidades (U)
        C = NUM / 100;          // Centena
        NUM = NUM % 100;        // Quedarse con los dos últimos dígitos
        D = NUM / 10;           // Decena
        U = NUM % 10;           // Unidad

        // Invertir el número
        NUMINV = (U * 100) + (D * 10) + C;

        // Mostrar el resultado
        Console.WriteLine($"\nNúmero original: {AUX}");
        Console.WriteLine($"Número invertido: {NUMINV}");
    }
}
