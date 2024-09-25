using System;
    public class CalculosMatematicos
    {
        public int Calcular(int primerNumero, int segundoNumero)
        {
            int suma = primerNumero + segundoNumero;
            int resta = primerNumero - segundoNumero;
            int multiplicacion = suma * resta;

            return multiplicacion;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Introduce el primer número: ");
            int primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            CalculosMatematicos calculadora = new CalculosMatematicos();
            int resultado = calculadora.Calcular(primerNumero, segundoNumero);

            Console.WriteLine($"La multiplicación es {resultado}");
        }
    }