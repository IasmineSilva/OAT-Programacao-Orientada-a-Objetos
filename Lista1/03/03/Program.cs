using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par ou impar");
            Console.WriteLine("__");
            Console.WriteLine("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());


            if (n1 % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }

            Console.ReadLine();
        }
    }
}
