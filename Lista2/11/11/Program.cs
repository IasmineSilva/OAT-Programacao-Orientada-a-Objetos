using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, VariavelTemporaria;

            Console.WriteLine("Efetuador de troca de valores entre variaveis");


            Console.WriteLine("Digite a variável A:  ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a variável B: ");
            B = int.Parse(Console.ReadLine());



            VariavelTemporaria = A;
            A = B;
            B = VariavelTemporaria;

            Console.WriteLine("A=" + A + " | B=" + B + "");
            Console.ReadLine();
        }
    }
}
