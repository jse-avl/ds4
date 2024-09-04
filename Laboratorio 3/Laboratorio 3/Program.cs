using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, suma, multiplicacion, resta;

        Console.Write("Introduce el primer numero:");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero:");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        suma = primerNumero + segundoNumero;

        resta = primerNumero - segundoNumero;

        multiplicacion = suma * resta;

        Console.WriteLine("La multiplicacion de {0} y {1} es {2}",suma, resta, multiplicacion);
    }
}