using System;

namespace Inicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            string nome = string.Empty;

            Console.WriteLine("Digite seu nome:");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Hello World! " + p.Nome);
            
            Console.ReadKey();


        }
    }
}
