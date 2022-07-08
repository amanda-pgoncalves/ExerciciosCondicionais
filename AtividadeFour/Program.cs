using System;

namespace AtividadeFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Codigo();
        }

        static void Codigo()
        {
            Console.Clear();
            Console.WriteLine("Informe o código do produto: ");
            string codigo = Console.ReadLine();

            Console.WriteLine("Informe a quantidade desejada: ");
            float quantidade = float.Parse(Console.ReadLine());

            switch (codigo)
            {
                case "100":
                    Console.WriteLine($"O valor total é: {1.70 * quantidade}");
                    break;
                case "101":
                    Console.WriteLine($"O valor total é:  {2.30 * quantidade}");
                    break;
                case "102":
                    Console.WriteLine($"O valor total é: {2.60 * quantidade}");
                    break;
                case "103":
                    Console.WriteLine($"O valor total é: {2.40 * quantidade}");
                    break;
                case "104":
                    Console.WriteLine($"O valor total é: {2.50 * quantidade}");
                    break;
                case "105":
                    Console.WriteLine($"O valor total é: {1.0 * quantidade}");
                    break;
                case "106": System.Environment.Exit(0); break;
                default: Codigo(); break;

            }

        }
    }
}