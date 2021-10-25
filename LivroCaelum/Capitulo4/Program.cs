using System;

namespace Capitulo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estruturas de controle
            double saldo = 100.0;
            double valorSaque = 10.0;
            double taxaSaque;

            if (saldo >= valorSaque) //o if será executado se a condição for verdadeira
            {
                
                saldo -= valorSaque;
                Console.WriteLine("Novo Saldo: "+ saldo); 
            }else
            {
                Console.WriteLine("Saldo insuficiente: ");
            }



        }
    }
}
