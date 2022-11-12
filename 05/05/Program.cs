using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                int dobro = numero * numero;
                Console.WriteLine("O dobro de {0} é: {1}", numero, dobro);
            }
            else
            {
                int triplo = numero * numero * numero;
                Console.WriteLine("O triplo de{0} é: {1}", numero, triplo);

            }
            Console.ReadLine();
        }
    }
}
