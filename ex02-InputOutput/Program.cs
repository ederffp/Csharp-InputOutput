using System;

namespace Projeto02
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Informe um numero para N1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um numero para N2: ");
            int n2 = int.Parse(Console.ReadLine());

            int result = Soma(n1, n2);

            string output = $"Resultado da soma entre {n1} e {n2} é: {result}";

            Console.WriteLine(output);

        }
        public static int Soma(int a, int b) { return a + b; }

    }
}
