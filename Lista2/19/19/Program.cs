using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine("Verificador de Triângulo\n\n");


            Console.WriteLine("Digite o lado A=");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B=");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado C=");
            C = int.Parse(Console.ReadLine());


            if (A < B + C && B < A + C && C < A + B)
            {
                if (A == B && B == C)
                {
                    Console.WriteLine("O triângulo é Eqüilátero.");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("O triângulo é Isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é Escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo");
            }
            Console.ReadLine();
        }
    }
}
