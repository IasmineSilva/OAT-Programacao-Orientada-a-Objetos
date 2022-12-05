using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            int c = int.Parse(Console.ReadLine());

            int soma = a + b;

            if (soma > c)
            {
                Console.WriteLine("Soma é maior que c");
            }
            else
            {
                Console.WriteLine("C é maior que soma A+B");
            }
            Console.ReadLine();
        }
    }
}
