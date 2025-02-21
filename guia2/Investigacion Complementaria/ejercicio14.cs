using System;

class Program
{
    static void Main()
    {
        // Definir los precios de los productos
        double precioLibro = 100.00;
        double precioCuaderno = 15.50;
        double precioPluma = 2.35;

        // Declarar variables para las cantidades de artículos vendidos
        int cantidadLibros, cantidadCuadernos, cantidadPlumas;

        // Solicitar al usuario las cantidades de cada artículo
        Console.Write("¿Cuántos libros vendió? ");
        cantidadLibros = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Cuántos cuadernos vendió? ");
        cantidadCuadernos = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Cuántas plumas vendió? ");
        cantidadPlumas = Convert.ToInt32(Console.ReadLine());

        // Calcular las ventas individuales de cada producto
        double ventaLibros = cantidadLibros * precioLibro;
        double ventaCuadernos = cantidadCuadernos * precioCuaderno;
        double ventaPlumas = cantidadPlumas * precioPluma;

        // Calcular la venta total
        double ventaTotal = ventaLibros + ventaCuadernos + ventaPlumas;

        // Mostrar los resultados
        Console.WriteLine($"\nLa venta de libros fue de: ${ventaLibros:F2}");
        Console.WriteLine($"La venta de cuadernos fue de: ${ventaCuadernos:F2}");
        Console.WriteLine($"La venta de plumas fue de: ${ventaPlumas:F2}");
        Console.WriteLine($"La venta total del día fue de: ${ventaTotal:F2}");
    }
}
