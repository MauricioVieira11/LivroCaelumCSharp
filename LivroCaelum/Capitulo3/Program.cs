using System;
using Xceed.Wpf.Toolkit;
using System.Globalization;

namespace Capitulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Comentário de múltiplas linhas
            ok?
             */
            string Nome = "TEstando LivroCaelum";
            int numeroDaConta = 1;
            double Saldo = 100.0;
            double valorDoSaque = 10.0;
            double taxa = 2.0;
            double taxa2 = 3;
            double taxa3 = 4;
            double taxa5 = 5;

            Saldo = Saldo - valorDoSaque;
            //Saldo -= valorDoSaque; -> é a mesma situação que o código acima!
            Console.WriteLine("O Saldo da conta após o saque é: " + Saldo.ToString("F2"));

            Saldo -= taxa; //diminui 2
            Console.WriteLine("O Saldo da conta após o saque é: " + Saldo);

            Saldo += taxa2; //acrescenta 3
            Console.WriteLine("O Saldo da conta após o saque é: " + Saldo);

            Saldo *= taxa3;
            Console.WriteLine("O Saldo da conta após o saque é: " + Saldo);

            Console.WriteLine("-----------------------");
            int valor = 1;
            short valorPequeno = (short)valor;

            Console.WriteLine("Valor modificado por casting: "+valorPequeno);
            Console.WriteLine("NOme: "+ Nome);

            Console.WriteLine();


        }
    }
}
