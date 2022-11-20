using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade_numeros = 10; 
            double media = 0;
            int[] numeros = new int[quantidade_numeros];

            for (int x = 0; x < quantidade_numeros; x++)
            {
                Console.WriteLine ("Digite o " + (x + 1) + "° número: ");
                numeros[x] = int.Parse(Console.ReadLine());
                media += numeros[x];
            }
            media = media / quantidade_numeros;
            Array.Sort(numeros);

            Console.WriteLine ("\nO menor número é: " + numeros[0]);
            Console.WriteLine ("O maior número é: " + numeros[quantidade_numeros - 1]);
            Console.WriteLine ("A média dos números é: " + media);
            Console.ReadLine();

        }
    }
}
