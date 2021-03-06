﻿using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        enum OpcoesMenuPrincipal

        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ExcluirCliente = 4,
            Sair = 5
        }


        private static OpcoesMenuPrincipal Menu()
        {

            // Pessoa p = new Pessoa();         classe abstrata não pode ser chamada!
            Console.WriteLine("Escolha sua opção");
            Console.WriteLine("");

            Console.WriteLine(" - Clientes ");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("");

            Console.WriteLine(" - Geral - ");
            Console.WriteLine("4 - Limpar Tela");
            Console.WriteLine("5 - Sair");

            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal) int.Parse(opcao);
            //Int.Parse(Console.ReadLine());
            
        }

        private static Cliente CadastrarCliente()
        {
            Cliente c = new Cliente();
            c._Endereco = new Endereco();

            Console.WriteLine("");

            Console.WriteLine("- INFORME OS DADOS DO CLIENTE -");

            Console.Write("Digite o nome: ");
            c.Nome = Console.ReadLine();

            Console.Write("Digite o CPF: ");
            c.Cpf = Console.ReadLine();          

            Console.Write("Digite Rua: ");
            c._Endereco.Rua = Console.ReadLine();

            Console.Write("Digite Complemento: ");
            c._Endereco.Complemento = Console.ReadLine();

            Console.Write("Digite Número: ");
            c._Endereco.Numero = int.Parse(Console.ReadLine());

            return c;

        }


        private static void MostrarCliente(Cliente c)
        {
            Console.WriteLine("");

            Console.WriteLine(" - CLIENTE CADASTRADO - " );
            Console.WriteLine("");
            Console.WriteLine("Nome: "+c.Nome );
            Console.WriteLine("CPF: "+ c.Cpf);
            Console.WriteLine("Rua: "+ c._Endereco.Rua);
            Console.WriteLine("Número: "+ c._Endereco.Numero);
            Console.WriteLine("Complemento: "+ c._Endereco.Complemento);           

            Console.WriteLine("");

        }


        private static void CadastrarEntregador()
        {
            Fornecedor e = new Fornecedor();

            Console.WriteLine("Digite o nome:");
            e.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Digite o CPF:");
            e.Cpf = Console.ReadLine();


        }

        private static void CadastrarFornecedor()
        {
            Fornecedor f = new Fornecedor();

            Console.WriteLine("Digite o nome:");
            f.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Digite o CPF:");
            f.Cpf = Console.ReadLine();


        }







        static void Main(string[] args)
        {

            OpcoesMenuPrincipal opcaoEscolhida = OpcoesMenuPrincipal.Sair;

            do
            {
                opcaoEscolhida = Menu();

                switch (opcaoEscolhida)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        MostrarCliente(CadastrarCliente());
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        break;
                    case OpcoesMenuPrincipal.ExcluirCliente:
                        break;
                    case OpcoesMenuPrincipal.Sair:
                        break;
                }

            } while (opcaoEscolhida!=OpcoesMenuPrincipal.Sair);
               
            

            Console.ReadKey();

        }
    }
}
