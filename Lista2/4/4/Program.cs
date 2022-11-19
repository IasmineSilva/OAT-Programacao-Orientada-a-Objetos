using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[4];

            Console.WriteLine("Calculador de valores numericos.");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite o valor " + (i + 1) + ": ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Resultados:");

            Console.WriteLine("Valor 1 e Valor 2:");
            Console.WriteLine("	" + valores[0] + " + " + valores[1] + " = " + (valores[0] + valores[1]) + "");
            Console.WriteLine("	" + valores[0] + " * " + valores[1] + " = " + (valores[0] * valores[1]) + "");
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("Valor 1 e Valor 3:");
            Console.WriteLine("	" + valores[0] + " + " + valores[2] + " = " + (valores[0] + valores[2]) + "");
            Console.WriteLine("	" + valores[0] + " * " + valores[2] + " = " + (valores[0] * valores[2]) + "");
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("Valor 1 e Valor 4:");
            Console.WriteLine("	" + valores[0] + " + " + valores[3] + " = " + (valores[0] + valores[3]) + "");
            Console.WriteLine("	" + valores[0] + " * " + valores[3] + " = " + (valores[0] * valores[3]) + "");
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("Valor 2 e Valor 3:");
            Console.WriteLine("	" + valores[1] + " + " + valores[2] + " = " + (valores[1] + valores[2]) + "");
            Console.WriteLine("	" + valores[1] + " * " + valores[2] + " = " + (valores[1] * valores[2]) + "");
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("Valor 2 e Valor 4:");
            Console.WriteLine("	" + valores[1] + " + " + valores[3] + " = " + (valores[1] + valores[3]) + "");
            Console.WriteLine("	" + valores[1] + " * " + valores[3] + " = " + (valores[1] * valores[3]) + "");
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("Valor 3 e Valor 4:");
            Console.WriteLine("	" + valores[2] + " + " + valores[3] + " = " + (valores[2] + valores[3]) + "");
            Console.WriteLine("	" + valores[2] + " * " + valores[3] + " = " + (valores[2] * valores[3]) + "");
            Console.ReadLine();
        }
    }
}
