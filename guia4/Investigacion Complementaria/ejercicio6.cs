using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            // Primer menú
            Console.Clear();
            Console.WriteLine("Primer Menú:");
            Console.WriteLine("a) Conversión de colones a dólares");
            Console.WriteLine("b) Conversión de millas a kms");
            Console.WriteLine("c) Conversión de grados Celsius a grados Fahrenheit");
            Console.WriteLine("d) Segundo menú");
            Console.WriteLine("e) Fin de menú");
            Console.Write("Seleccione una opción (a..e): ");
            char opcionPrincipal = Convert.ToChar(Console.ReadLine().ToLower());

            switch (opcionPrincipal)
            {
                case 'a':
                    // Conversión de colones a dólares
                    Console.Write("Ingrese el monto en colones: ");
                    double colones = Convert.ToDouble(Console.ReadLine());
                    double dolares = colones / 600;  // Supongamos que 1 dólar = 600 colones
                    Console.WriteLine($"El monto en dólares es: {dolares} USD");
                    break;

                case 'b':
                    // Conversión de millas a kilómetros
                    Console.Write("Ingrese el valor en millas: ");
                    double millas = Convert.ToDouble(Console.ReadLine());
                    double kms = millas * 1.60934;  // 1 milla = 1.60934 km
                    Console.WriteLine($"El valor en kilómetros es: {kms} km");
                    break;

                case 'c':
                    // Conversión de grados Celsius a grados Fahrenheit
                    Console.Write("Ingrese la temperatura en grados Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;  // Fórmula de conversión
                    Console.WriteLine($"La temperatura en grados Fahrenheit es: {fahrenheit} °F");
                    break;

                case 'd':
                    // Segundo menú
                    bool subMenuActivo = true;
                    while (subMenuActivo)
                    {
                        Console.Clear();
                        Console.WriteLine("Segundo Menú:");
                        Console.WriteLine("1) ¿Es positivo o negativo?");
                        Console.WriteLine("2) Área de un triángulo");
                        Console.WriteLine("3) Fin del submenú");
                        Console.Write("Seleccione una opción (1..3): ");
                        int opcionSubMenu = Convert.ToInt32(Console.ReadLine());

                        switch (opcionSubMenu)
                        {
                            case 1:
                                // Verificar si el número es positivo o negativo
                                Console.Write("Ingrese un número: ");
                                double numero = Convert.ToDouble(Console.ReadLine());
                                if (numero > 0)
                                    Console.WriteLine("El número es positivo.");
                                else if (numero < 0)
                                    Console.WriteLine("El número es negativo.");
                                else
                                    Console.WriteLine("El número es cero.");
                                break;

                            case 2:
                                // Calcular el área de un triángulo
                                Console.Write("Ingrese la base del triángulo: ");
                                double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese la altura del triángulo: ");
                                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                                double area = (baseTriangulo * alturaTriangulo) / 2;
                                Console.WriteLine($"El área del triángulo es: {area} unidades cuadradas.");
                                break;

                            case 3:
                                // Fin del submenú
                                subMenuActivo = false;
                                break;

                            default:
                                Console.WriteLine("Opción no válida en el submenú.");
                                break;
                        }

                        // Espera antes de regresar al submenú
                        if (subMenuActivo)
                        {
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                    }
                    break;

                case 'e':
                    // Fin del menú principal
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            // Espera antes de mostrar el menú nuevamente
            if (continuar)
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Programa finalizado.");
    }
}
