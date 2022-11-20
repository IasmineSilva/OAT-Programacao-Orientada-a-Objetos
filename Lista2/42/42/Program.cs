using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, maior, menor;
            Console.WriteLine("///Digite 0 para sair////");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            menor = numero;
            maior = numero;

            do
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }
                if (numero < menor && numero != 0)
                {
                    menor = numero;
                }

            } while (numero != 0);

            Console.WriteLine($"\nO mmior numero digitado é {menor}   O menor número digitaado é {maior}");

            Console.ReadLine();

        }
    }
}
