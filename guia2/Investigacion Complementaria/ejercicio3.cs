using System;

class Program
{
    static void Main()
    {
        // Solicitar el costo del artículo y la cantidad de dinero entregado por el cliente
        Console.Write("Ingresa el costo del artículo: ");
        double costoArticulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la cantidad de dinero entregado por el cliente: ");
        double dineroEntregado = Convert.ToDouble(Console.ReadLine());

        // Calcular el cambio
        double cambio = dineroEntregado - costoArticulo;

        // Verificar si el dinero entregado es suficiente
        if (cambio < 0)
        {
            Console.WriteLine("El dinero entregado no es suficiente para cubrir el costo del artículo.");
        }
        else
        {
            // Mostrar el cambio que se debe entregar
            Console.WriteLine($"El cambio a devolver es: {cambio} unidades de dinero.");
        }
    }
}
