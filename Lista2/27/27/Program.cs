using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            Console.WriteLine("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            long[] numeros = new long[quantidade];
            for (int x = 0; x < numeros.Length; x++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[x] = long.Parse(Console.ReadLine());
            }
            for (int x = 0; x < numeros.Length; x++)
            {
                long resultado = 1;
                for (long y = numeros[x]; y > 0; y--)
                {
                    resultado = y * resultado;
                }
                Console.WriteLine("O fatorial de " + numeros[x] + " é: " + resultado);
                Console.ReadLine();
            }
        }
    }
}
