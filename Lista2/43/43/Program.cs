using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double graosCasa = 1, casasTabuleiro = 64;
            int graos = 1;

            for (int x = 1; x < casasTabuleiro; x++)
            {
                graosCasa = graosCasa * 2;
                graos += (int)graosCasa;
            }

            Console.WriteLine("\nO quantidade de grãos é: " + graos);
            Console.ReadLine();

        }
    }
}
