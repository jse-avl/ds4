internal class Program
{
    private static void Main(string[] args)
    {
        int b, h, suma, perimetro;

        Console.Write("Introduce el valor de la base:");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el valor de la altura:");
        h = Convert.ToInt32(Console.ReadLine());

        suma = b + h;

        perimetro = 2 * suma;

        Console.WriteLine("El perimetro del rectangulo es {0}", perimetro);
    }
}