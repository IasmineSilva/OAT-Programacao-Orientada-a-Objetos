using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro numero: ");
            int B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                int C = A + B;
                Console.WriteLine("A soma de {0} e {1} é: {2}", A, B, C);
            }
            else
            {
                int C = A * B;
                Console.WriteLine("A Multiplicação entre {0} e {1} é: {2}", A, B, C);

            }
            Console.ReadLine();
        }
    }
}
