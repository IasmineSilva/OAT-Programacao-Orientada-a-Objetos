using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.Write("\n\n");
            foreach (int i in numeros) Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
