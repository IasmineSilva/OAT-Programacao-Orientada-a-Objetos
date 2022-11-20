using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAtual, maior, menor;

            Console.WriteLine("Digite um número (negativo para sair): ");
            numeroAtual = int.Parse(Console.ReadLine());

            if (numeroAtual >= 0)
            {
                menor = numeroAtual;
                maior = numeroAtual;
                while (numeroAtual >= 0)
                {
                    Console.WriteLine("Digite outro número: ");
                    numeroAtual = int.Parse(Console.ReadLine());
                    if (numeroAtual > maior)
                    {
                        maior = numeroAtual;
                    }
                    if (numeroAtual < menor && numeroAtual >= 0)
                    {
                        menor = numeroAtual;
                    }
                }
                Console.WriteLine("\nO maior número foi " + maior + " e o menor foi " + menor);
                Console.ReadLine();
            }
        }
    }
}
