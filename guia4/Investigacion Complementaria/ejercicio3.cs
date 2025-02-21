using System;

class Program
{
    static void Main()
    {
        int opcion;
        
        // Mostrar el menú de opciones
        Console.WriteLine("Seleccione el tipo de triángulo:");
        Console.WriteLine("1. Equilátero");
        Console.WriteLine("2. Isósceles");
        Console.WriteLine("3. Escaleno");
        
        // Solicitar la opción del usuario
        Console.Write("Ingrese su opción (1, 2, o 3): ");
        opcion = Convert.ToInt32(Console.ReadLine());
        
        // Declarar las variables para los lados
        double lado1, lado2, baseTriangulo, perimetro;

        switch(opcion)
        {
            case 1: // Triángulo equilátero
                Console.Write("Ingrese el valor del lado: ");
                lado1 = Convert.ToDouble(Console.ReadLine());
                perimetro = 3 * lado1;
                Console.WriteLine($"El perímetro del triángulo equilátero es: {perimetro}");
                break;
                
            case 2: // Triángulo isósceles
                Console.Write("Ingrese el valor de los dos lados iguales: ");
                lado1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el valor de la base: ");
                baseTriangulo = Convert.ToDouble(Console.ReadLine());
                perimetro = (2 * lado1) + baseTriangulo;
                Console.WriteLine($"El perímetro del triángulo isósceles es: {perimetro}");
                break;

            case 3: // Triángulo escaleno
                Console.Write("Ingrese el valor del primer lado: ");
                lado1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el valor del segundo lado: ");
                lado2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el valor de la base: ");
                baseTriangulo = Convert.ToDouble(Console.ReadLine());
                double hipotenusa = Math.Sqrt(Math.Pow(lado1, 2) + Math.Pow(lado2, 2));
                perimetro = lado1 + lado2 + hipotenusa;
                Console.WriteLine($"El perímetro del triángulo escaleno es: {perimetro}");
                break;
                
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
