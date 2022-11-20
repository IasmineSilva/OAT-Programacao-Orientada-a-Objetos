using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine ("Digite o " + (x + 1) + "° Número do vetor: ");
                vetor[x] = int.Parse(Console.ReadLine());
            }

            
            int numeroX;
            Console.WriteLine ("Digite o número X: ");
            numeroX = int.Parse(Console.ReadLine());

            int maiores = 0, menores = 0, iguais = 0;
            Console.WriteLine ("Números maiores que o número X:\n");
            for (int w = 0; w < 10; w++)
            {
                if (vetor[w] > numeroX)
                {
                    Console.WriteLine (vetor[w]);
                    maiores++;
                }
                else if (vetor[w] == numeroX)
                {
                    iguais++;
                }
                else
                {
                    menores++;
                }
            }
            
            Console.WriteLine ("\nMaiores: " + maiores + "\nIguais: " + iguais + "\nMenores: " + menores + "\n");
            Console.ReadLine();
        }
    }
}
