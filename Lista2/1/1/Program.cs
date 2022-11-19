using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int estoque_medio, estoque_maximo, estoque_minimo;

            Console.WriteLine("Estoque Médio de uma peça");
            Console.WriteLine("-------------------------");


            Console.WriteLine("Digite a quantidade máxima da peça:");
            estoque_maximo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade mínima da peça:");
            estoque_minimo = int.Parse(Console.ReadLine());

            estoque_medio = estoque_maximo + estoque_minimo / 2;

            Console.WriteLine("A média da peça é :" + estoque_medio);
            Console.ReadLine();
        }
    }
}
