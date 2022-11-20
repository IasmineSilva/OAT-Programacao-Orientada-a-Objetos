using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int C;
            double N, E = 0, PrecoHora, PrecoExcedente;
            bool continuar = true;
            char texto;

            do
            {
                E = 0;
                PrecoHora = 10;
                PrecoExcedente = PrecoHora * 2;

                Console.WriteLine ("Digite o código do operário: ");
                C = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de horas trabalhadas: ");
                N = double.Parse(Console.ReadLine());

                if (N > 50)
                {
                    E = N - 50;
                }

                Console.WriteLine ("\nID: " + C + "\nSalario: " + (N * PrecoHora) + "\nSalario excedente: " + (E * PrecoExcedente) + "\nSalario total: " + (E * PrecoExcedente + N * PrecoHora) + "\n\nDeseja encerrar o programa?(s/N) ");
                texto = char.Parse(Console.ReadLine());
                if (texto == 's' || texto == 'S')
                {
                    continuar = false;
                }

            } while (continuar);
        }
    }
}
