using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NVoltas, total = 0, media, MTempo = 0, MVolta = 0;

            Console.WriteLine("Digite o número de voltas: ");
            NVoltas = Convert.ToInt32(Console.ReadLine());

            int[] tempos = new int[NVoltas];
            for (int x = 0; x < NVoltas; x++)
            {
                Console.WriteLine($"Digite o tempo da {x + 1}ª volta (em segundos): ");
                tempos[x] = Convert.ToInt32(Console.ReadLine());
                total += tempos[x];
                if (tempos[x] < MTempo || x == 0)
                {
                    MTempo = tempos[x];
                    MVolta = x + 1;
                }
            }
            media = total / NVoltas;


            Console.WriteLine($"i.   O melhor tempo foi: {MTempo} segundos.");
            Console.WriteLine($"ii.  Melhor volta foi: {MVolta}ª");
            Console.WriteLine($"iii. A média de tempo foi: {media}");
            Console.ReadLine();
        }
    }
}
