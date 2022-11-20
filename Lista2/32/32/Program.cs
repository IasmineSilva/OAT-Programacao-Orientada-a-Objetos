using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero, Resultado = 0;

            do
            {
                Console.WriteLine("Digite um numero maior que 0 e menor que 10: ");
                Numero = int.Parse(Console.ReadLine());
            } while (Numero <= 0 || Numero >= 10);

            for (int x = Numero; x < 40 + Numero; x++)
            {
                if (x % 2 == 1)
                {
                    Resultado += x * x;
                }
            }
            Console.WriteLine("O resultado da soma dos quadrados dos 20 primeiros numeros inteiros positivos impares a partir do numero informado é: " + Resultado);
            Console.ReadLine();
        }
    }
}
