using System;

namespace AtividadeOne
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
            Console.WriteLine("Digite o código do produto: ");
            string produto = Console.ReadLine();

            switch (produto)
            {
                case "1": Console.WriteLine("Alimento não-perecível"); break;
                case "2":
                case "3":
                case "4": Console.WriteLine("Alimento perecível"); break;
                case "5":
                case "6": Console.WriteLine("Vestuário"); break;
                case "7": Console.WriteLine("Higiene Pessoal"); break;
                case "8":
                case "9":
                case "10":
                case "11":
                case "12":
                case "13":
                case "14":
                case "15": Console.WriteLine("Limpeza e Utensílios"); break;

                default:
                    Console.WriteLine("código Inválido!!!");
                    break;
            }
        }
    }
}