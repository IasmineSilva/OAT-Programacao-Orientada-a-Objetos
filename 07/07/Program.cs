using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" soma par e ímpar");
            Console.WriteLine("__");
            Console.WriteLine("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());

            int resultado;
            if (n1 % 2 == 0)
            {
                resultado = n1 + 5;
            }
            else
            {
               resultado = n1 + 8;
            }
            Console.ReadLine();

        }
    }
}
