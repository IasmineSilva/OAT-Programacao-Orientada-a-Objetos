using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd;

            Console.WriteLine("Quantos numeros deseja inserir?: ");
            qtd = Convert.ToInt32(Console.ReadLine());


            int[] v1 = new int[qtd];
            int[] v2 = new int[qtd];

            for (int x = 0; x < qtd; x++)
            {
                Console.Write($"Digite um valor para a posição {x + 1} do vetor 1: ");
                v1[x] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (int x = 0; x < qtd; x++)
            {
                Console.Write($"Digite um valor para a posição {x + 1} do vetor 2: ");
                v2[x] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (int x = 0; x < qtd; x++)
            {
                if (v1[x] == v2[x])
                {
                    Console.WriteLine($"Valores das Posições {x + 1} dos vetores é igual.");
                }
                else
                {
                    Console.WriteLine($" Valores das Posições {x + 1} dos vetores não são iguais");
                }
                Console.ReadLine();
            }
        }
    }
}
