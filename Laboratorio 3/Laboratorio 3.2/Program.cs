using System;

public class CalculosMatematicos
{
    public double CalcularArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        double radio;

        Console.Write("Introduce el radio del círculo: ");
        radio = Convert.ToDouble(Console.ReadLine());

        CalculosMatematicos calculadora = new CalculosMatematicos();
        double area = calculadora.CalcularArea(radio);

        Console.WriteLine($"El área del círculo es {area}");
    }
}