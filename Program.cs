using System;
using Ex8;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace PessoaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "João";
            pessoa.DataNascimento = new DateTime(1984, 1, 2);
            pessoa.MostrarIdade();

            Console.ReadLine();
        }
    }
}