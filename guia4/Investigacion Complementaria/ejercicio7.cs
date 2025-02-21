using System;

class Program
{
    static void Main()
    {
        // Pedir el límite de crédito actual de la persona
        Console.Write("Ingrese el límite de crédito actual de la tarjeta: ");
        double limiteCreditoActual = Convert.ToDouble(Console.ReadLine());

        // Pedir el tipo de tarjeta
        Console.WriteLine("Ingrese el tipo de tarjeta (1, 2, 3 o cualquier otro número): ");
        int tipoTarjeta = Convert.ToInt32(Console.ReadLine());

        // Calcular el aumento según el tipo de tarjeta
        double aumento = 0;
        
        switch (tipoTarjeta)
        {
            case 1:
                aumento = 0.25;  // Aumento del 25% para tarjeta tipo 1
                break;
            case 2:
                aumento = 0.35;  // Aumento del 35% para tarjeta tipo 2
                break;
            case 3:
                aumento = 0.40;  // Aumento del 40% para tarjeta tipo 3
                break;
            default:
                aumento = 0.50;  // Aumento del 50% para cualquier otro tipo de tarjeta
                break;
        }

        // Calcular el nuevo límite de crédito
        double nuevoLimiteCredito = limiteCreditoActual * (1 + aumento);

        // Mostrar el nuevo límite de crédito
        Console.WriteLine($"El nuevo límite de crédito es: {nuevoLimiteCredito:C2}"); // Formato monetario
    }
}
