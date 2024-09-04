internal class Program
{
    private static void Main(string[] args)
    {
        double calculoArea, radio, p, multiplicacionP, pi;

        pi = 3.1416;

        Console.Write("Introduce el perímetro: ");
        p = Convert.ToDouble(Console.ReadLine());

        multiplicacionP = p * p;

        calculoArea = pi * multiplicacionP;

        Console.WriteLine("El área del círculo es de {0}", calculoArea);
    }
}
