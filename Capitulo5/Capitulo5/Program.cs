using System;

namespace Capitulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.00;

            for (int i = 1; i<=12;i++)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            Console.WriteLine("Valor investido usando o For: "+valorInvestido.ToString("F2"));
            Console.WriteLine();

            double valorInvestido2 = 1000.00;
            int i2 = 1;

            while (i2 <=  12)
            {
                valorInvestido2 = valorInvestido2 * 1.01;
                i2 += 1;
                Console.WriteLine("Valor investido2 usando While: " + valorInvestido2.ToString("F2"));
            }
            
        }
    }
}
