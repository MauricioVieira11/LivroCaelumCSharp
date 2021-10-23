using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo8
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Rg { get; set; }
        public double Cpf { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public Cliente(string nome, int idade, int rg, double cpf)
        {
            Nome = nome;
            Idade = Idade;
            Rg = rg;
            Cpf = cpf;

            
        }
    }
}
