using System;

class Program
{
    static void Main()
    {
        // Solicitar el ángulo agudo en grados y la hipotenusa
        Console.Write("Ingresa el valor del ángulo agudo en grados: ");
        double anguloGrados = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la longitud de la hipotenusa: ");
        double hipotenusa = Convert.ToDouble(Console.ReadLine());

        // Convertir el ángulo de grados a radianes (ya que las funciones trigonométricas en C# usan radianes)
        double anguloRadianes = anguloGrados * Math.PI / 180;

        // Calcular los catetos utilizando las funciones trigonométricas
        double catetoOpuesto = hipotenusa * Math.Sin(anguloRadianes);
        double catetoAdyacente = hipotenusa * Math.Cos(anguloRadianes);

        // Mostrar los resultados
        Console.WriteLine($"\nEl cateto opuesto es: {catetoOpuesto:F2}");
        Console.WriteLine($"El cateto adyacente es: {catetoAdyacente:F2}");
    }
}
