using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[3];

            for (int x = 0; x < 3; x++)
            {

                Console.WriteLine("Verificador de variaveis");

                for (x = 0; x < 3; x++)
                {
                    Console.WriteLine("Digite o valor " + (x + 1) + ": ");
                    valores[x] = int.Parse(Console.ReadLine());
                    while (valores[x] <= 0)
                    {
                        Console.WriteLine("Digite um valor v�lido no valor " + (x + 1) + ": ");
                        valores[x] = int.Parse(Console.ReadLine());
                    }
                }
                Array.Sort(valores);
                Console.WriteLine("Exibe o menor valor lido multiplicado pelo maior: " + (valores[0] * valores[2]) + "  E o maior valor dividido pelo menor: " + (valores[2] / valores[0]));
                valores[x] = int.Parse(Console.ReadLine());
                while (valores[x] <= 0)
                {
                    Console.WriteLine("Digite um valor v�lido no valor " + (x + 1) + ": ");
                    valores[x] = int.Parse(Console.ReadLine());
                }
            }
            Array.Sort(valores);
            Console.WriteLine("Exibe o menor valor lido multiplicado pelo maior: " + (valores[0] * valores[2]) + "  E o maior valor dividido pelo menor: " + (valores[2] / valores[0]));
            Console.ReadLine();
        }
    }
}
