using System;

namespace Inicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = string.Empty;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Hello World" + nome);

            Console.ReadKey();


        }
    }
}
