using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

            Console.WriteLine("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            int[] Numeros = new int[quantidade];

            for (int x = 0; x < quantidade; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + "° Número: ");
                Numeros[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nA ordem contrária é:\n");
            for (int y = quantidade - 1; y >= 0; y--)
            {
                Console.WriteLine(Numeros[y]);
            }
            Console.ReadLine();
        }
    }
}
