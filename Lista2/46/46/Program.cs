using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

            Console.WriteLine ("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            int[] vetorX = new int[quantidade];
            int[] vetorY = new int[quantidade];

            for (int x = 0; x < quantidade; x++)
            {
                Console.WriteLine ("Digite o " + (x + 1) + "° Número do vetor X: ");
                vetorX[x] = int.Parse(Console.ReadLine());
            }
            for (int y = 0; y < quantidade; y++)
            {
                Console.WriteLine ("Digite o " + (y + 1) + "° Número do vetor Y: ");
                vetorY[y] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine ("A multiplicação dos vetores é:\n");
            for (int w = 0; w < quantidade; w++)
            {
                Console.WriteLine (vetorX[w] + " * " + vetorY[w] + " = " + (vetorY[w] * vetorX[w]));
            }
            Console.ReadLine();
        }
    }
}
