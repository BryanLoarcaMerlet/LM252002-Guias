using System;

class Program
{
    static void Main()
    {
        // Solicitar el radio, generatriz y altura del cono
        Console.Write("Ingresa el radio (r) de la base del cono: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la generatriz (g) del cono: ");
        double generatriz = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la altura (h) del cono: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Calcular el área de la base (AB)
        double areaBase = Math.PI * Math.Pow(radio, 2);

        // Calcular el área lateral (AL)
        double areaLateral = Math.PI * radio * generatriz;

        // Calcular el área total (AT)
        double areaTotal = areaBase + areaLateral;

        // Calcular el volumen (VOL)
        double volumen = (1.0 / 3.0) * areaBase * altura;

        // Mostrar los resultados
        Console.WriteLine($"\nÁrea de la base: {areaBase:F2} unidades cuadradas");
        Console.WriteLine($"Área lateral: {areaLateral:F2} unidades cuadradas");
        Console.WriteLine($"Área total: {areaTotal:F2} unidades cuadradas");
        Console.WriteLine($"Volumen: {volumen:F2} unidades cúbicas");
    }
}
