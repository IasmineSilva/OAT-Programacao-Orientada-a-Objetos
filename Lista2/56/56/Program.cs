using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NumInt = new int[5];
            int QtdPares = 0, x = 0;

            while (x < 5)
            {
                Console.WriteLine($"Digite um {x + 1}º número: ");
                NumInt[x] = Convert.ToInt32(Console.ReadLine()); ;
                if (NumInt[x] >= 0)
                {
                    if (NumInt[x] % 5 == 0 && NumInt[x] % 2 == 0)
                    {
                        QtdPares++;
                    }
                    x++;
                }
            }

            Console.WriteLine($"\nA quantidade de números pares e multiplos de 5 é: {QtdPares}");
            Console.ReadLine();
        }
    }
}
