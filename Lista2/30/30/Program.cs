using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            Console.WriteLine("Digite um número: ");
            numero = double.Parse(Console.ReadLine());
            Console.WriteLine();


            for (int x = 1; x <= 10; x++)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($" {x} x {i} = {x * i}");

                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
        
    }
    
}
