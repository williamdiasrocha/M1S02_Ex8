using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex8
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public void MostrarIdade()
        {
            int idade = CalcularIdade();
            Console.WriteLine("Nome {0} tem a idade {1}", Nome, idade);
        }

        private int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNascimento.Year;
            if (DataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
    }
}