using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            // Menú principal
            Console.Clear();
            Console.WriteLine("Menú de conversiones:");
            Console.WriteLine("1. Kg a Libras");
            Console.WriteLine("2. Kg a Onzas");
            Console.WriteLine("3. Kg a Toneladas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción (1-4): ");
            
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Declarar la variable para el resultado
            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    // Conversión de Kg a Libras
                    Console.Write("Ingrese el valor en kilogramos: ");
                    double kgLibras = Convert.ToDouble(Console.ReadLine());
                    resultado = kgLibras * 2.20462; // 1 Kg = 2.20462 libras
                    Console.WriteLine($"{kgLibras} Kg equivalen a {resultado:F2} libras.");
                    break;

                case 2:
                    // Conversión de Kg a Onzas
                    Console.Write("Ingrese el valor en kilogramos: ");
                    double kgOnzas = Convert.ToDouble(Console.ReadLine());
                    resultado = kgOnzas * 35.274; // 1 Kg = 35.274 onzas
                    Console.WriteLine($"{kgOnzas} Kg equivalen a {resultado:F2} onzas.");
                    break;

                case 3:
                    // Conversión de Kg a Toneladas
                    Console.Write("Ingrese el valor en kilogramos: ");
                    double kgToneladas = Convert.ToDouble(Console.ReadLine());
                    resultado = kgToneladas / 1000; // 1 tonelada = 1000 Kg
                    Console.WriteLine($"{kgToneladas} Kg equivalen a {resultado:F3} toneladas.");
                    break;

                case 4:
                    // Salir del programa
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

            // Espera para continuar
            if (continuar)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Programa finalizado.");
    }
}
