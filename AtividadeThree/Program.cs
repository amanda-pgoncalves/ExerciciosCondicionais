using System;

namespace AtividadeThree
{
    class Program
    {

        static void Main(string[] args)
        {
            Numero();

        }

        static void Numero()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Número: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Número: ");
            float numero2 = float.Parse(Console.ReadLine());
            Opcao(numero1, numero2);

        }

        static void Opcao(float numero1, float numero2)
        {

            Console.WriteLine("O que deseja fazer: ");
            Console.WriteLine("1 - Média entre os números digitados: ");
            Console.WriteLine("2 - Diferença entre os números: ");
            Console.WriteLine("3 - Produto entre os números digitados: ");
            Console.WriteLine("4 - Divisão do primeiro pelo segundo: ");

            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Media(numero1, numero2); break;
                case 2: Diferenca(numero1, numero2); break;
                case 3: Produto(numero1, numero2); break;
                case 4: Divisao(numero1, numero2); break;
                case 5: System.Environment.Exit(0); break;
                default: Opcao(numero1, numero2); break;
            }
        }

        static void Media(float numero1, float numero2)
        {
            float resultado = (numero1 + numero2) / 2;
            Console.WriteLine($"A média dos dois número são: {resultado}");
            Console.WriteLine("Precione qualquer tecla para continuar... ");
            Console.ReadKey();
            Numero();

        }

        static void Diferenca(float numero1, float numero2)
        {
            float resultado = numero1 - numero2;
            Console.WriteLine($"A diferença dos dois número são: {resultado}");
            Console.WriteLine("Precione qualquer tecla para continuar... ");
            Console.ReadKey();
            Numero();
        }

        static void Produto(float numero1, float numero2)
        {
            float resultado = numero1 * numero2;
            Console.WriteLine($"O produto dos dois número são: {resultado}");
            Console.WriteLine("Precione qualquer tecla para continuar... ");
            Console.ReadKey();
            Numero();
        }

        static void Divisao(float numero1, float numero2)
        {
            float resultado = numero1 / numero2;
            Console.WriteLine($"A divisão dos dois número são: {resultado}");
            Console.WriteLine("Precione qualquer tecla para continuar... ");
            Console.ReadKey();
            Numero();
        }
    }
}