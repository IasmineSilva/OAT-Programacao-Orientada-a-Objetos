using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Verificador de numeros positivos ou negativos");

            do
            {
                Console.WriteLine("Digite um número, digite 0 para sair: ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("O número é negativo");
                }
            } while (numero != 0);
            Console.ReadLine();
        }
    }
    
}
