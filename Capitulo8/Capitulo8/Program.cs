using System;

namespace Capitulo8
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Guilherme = new Cliente("Guilherme");
            Guilherme.Nome = "Guilherme";
            Guilherme.Idade = 21;
            Guilherme.Cpf = 123456789;
            Guilherme.Rg = 334455;

            Console.WriteLine(" NOme: "+Guilherme.Nome+"\n Idade: "+Guilherme.Idade
                +"\n CPF: "+Guilherme.Cpf+"\n RG: "+Guilherme.Rg);

        }
    }
}
