using System;

namespace AtividadeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Nota();
        }

        static void Nota()
        {
            Console.Clear();
            Console.WriteLine("Primera nota: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            float resultado = nota1 + nota2;
            Console.WriteLine($"Total: {resultado}");

            float media = resultado / 2;
            Console.WriteLine($"Média: {media}");

            if (media <= 4)
            {
                Console.WriteLine("Reprovado");
            }
            if ((media >= 4.1) && (media <= 7))
            {
                Console.WriteLine("Exame");
            }
            if ((media >= 7.1) && (media <= 10))
            {
                Console.WriteLine("Aprovado");
            }

        }
    }
}