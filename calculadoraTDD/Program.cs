using System;

namespace CalculadoraTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();

            Console.WriteLine("Calculadora TDD");
            Console.WriteLine($"2 + 3 = {calc.Somar(2, 3)}");
            Console.WriteLine($"5 - 2 = {calc.Subtrair(5, 2)}");
            Console.WriteLine($"4 * 3 = {calc.Multiplicar(4, 3)}");
            Console.WriteLine($"10 / 2 = {calc.Dividir(10, 2)}");

            Console.WriteLine("\nHistórico de operações:");
            foreach (var item in calc.Historico())
            {
                Console.WriteLine(item);
            }
        }
    }
}
