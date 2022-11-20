using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PrimeiroNumero, SegundoNumero, Diferenca;

            Console.WriteLine("Verificador de números");


            Console.WriteLine("Digite o primeiro número:  ");
            PrimeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o segundo número:");
            SegundoNumero = int.Parse(Console.ReadLine());


            if (PrimeiroNumero >= SegundoNumero)
            {
                Diferenca = PrimeiroNumero - SegundoNumero;
            }
            else
            {
                Diferenca = SegundoNumero - PrimeiroNumero;
            }

            Console.WriteLine("A diferença do menor para o menor é " + Diferenca);
            Console.ReadLine();
        }
    }
}
