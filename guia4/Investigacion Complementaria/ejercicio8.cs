using System;

class Program
{
    static void Main()
    {
        // Definir las zonas y costos por gramo
        const double COSTO_AMERICA_NORTE = 11.00;  // Zona 1
        const double COSTO_AMERICA_CENTRAL = 10.00;  // Zona 2
        const double COSTO_AMERICA_SUR = 12.00;  // Zona 3
        const double COSTO_EUROPA = 24.00;  // Zona 4
        const double COSTO_ASIA = 27.00;  // Zona 5

        // Solicitar el peso del paquete
        Console.Write("Ingrese el peso del paquete en gramos: ");
        double pesoPaquete = Convert.ToDouble(Console.ReadLine());

        // Validar que el peso sea menor o igual a 5000 gramos (5 kg)
        if (pesoPaquete > 5000)
        {
            Console.WriteLine("El paquete excede el límite de peso permitido (5 kg). El envío es rechazado.");
        }
        else
        {
            // Solicitar la zona de destino
            Console.WriteLine("Seleccione la zona de destino:");
            Console.WriteLine("1. América del Norte");
            Console.WriteLine("2. América Central");
            Console.WriteLine("3. América del Sur");
            Console.WriteLine("4. Europa");
            Console.WriteLine("5. Asia");
            Console.Write("Ingrese el número de la zona (1-5): ");
            int zonaDestino = Convert.ToInt32(Console.ReadLine());

            // Variable para el costo de envío
            double costoEnvio = 0.0;

            // Calcular el costo según la zona seleccionada
            switch (zonaDestino)
            {
                case 1:
                    costoEnvio = pesoPaquete * COSTO_AMERICA_NORTE;
                    break;
                case 2:
                    costoEnvio = pesoPaquete * COSTO_AMERICA_CENTRAL;
                    break;
                case 3:
                    costoEnvio = pesoPaquete * COSTO_AMERICA_SUR;
                    break;
                case 4:
                    costoEnvio = pesoPaquete * COSTO_EUROPA;
                    break;
                case 5:
                    costoEnvio = pesoPaquete * COSTO_ASIA;
                    break;
                default:
                    Console.WriteLine("Zona no válida.");
                    return;
            }

            // Mostrar el costo de envío
            Console.WriteLine($"El costo del envío a la zona seleccionada es: ${costoEnvio:F2}");
        }
    }
}
