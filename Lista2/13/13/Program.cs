using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Quantidade = 3;
            int[] Numeros = new int[Quantidade];

            Console.WriteLine("Ordenador de números");

            for (int x = 0; x < Quantidade; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + " número:  ");
                Numeros[x] = int.Parse(Console.ReadLine());
            }

            Array.Sort(Numeros);
            Array.Reverse(Numeros);
            Console.WriteLine("Os Números em ordem decrescente são: ");

            foreach (int x in Numeros) Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
