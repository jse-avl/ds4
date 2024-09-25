﻿class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer lado del triángulo: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo lado del triángulo: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer lado del triángulo: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Los lados ingresados no forman un triángulo.");
        }
    }
}