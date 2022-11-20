using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero = 0, QuantPar = 0, QuantImpar = 0;

            while (Numero >= 0)
            {

                Console.WriteLine("Digite um numero (numeros negativos finalizam): ");
                Numero = int.Parse(Console.ReadLine());
                if (Numero >= 0)
                {
                    if (Numero % 2 == 0)
                    {
                        QuantPar++;
                    }
                    else
                    {
                        QuantImpar++;
                    }
                }
            }

            Console.WriteLine("Quantidade de Numeros Pares: " + QuantPar + "Quantidade de Numeros Impares: " + QuantImpar);
            Console.ReadLine();
        }
    }
}
