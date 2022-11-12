using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;

            Console.WriteLine("Digite 0 para falso e 1 para verdadeiro: ");
            Console.WriteLine("Digite o primeiro número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = int.Parse(Console.ReadLine());

            if (n1 == 0)
                Console.WriteLine("Numero 1: Falso");
            else if (n1 == 1)
                Console.WriteLine("Numero 1: Verdadeiro");
            else
                Console.WriteLine("Número 1 inválido!");

            if (n2 == 0)
                Console.WriteLine("Numero 2: Falso");
            else if (n2 == 1)
                Console.WriteLine("Numero 2: Verdadeiro");
            else
                Console.WriteLine("Número 2 inválido!");
            Console.ReadKey();
        }
    }
}
