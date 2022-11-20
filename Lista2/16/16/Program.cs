using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PrimeiroNumero, SegundoNumero;

            Console.WriteLine("Verificador de números");


            Console.WriteLine("Digite o primeiro número:  ");
            PrimeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:  ");
            SegundoNumero = int.Parse(Console.ReadLine());


            if (PrimeiroNumero > SegundoNumero)
            {
                Console.WriteLine("O primeiro número é maior que o segundo número.");
            }
            else if (PrimeiroNumero < SegundoNumero)
            {
                Console.WriteLine("O primeiro número é menor que o segundo número.");
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }
            Console.ReadLine();
        }
    }
}
