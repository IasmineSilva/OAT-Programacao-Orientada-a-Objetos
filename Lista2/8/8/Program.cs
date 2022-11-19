using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double RaioLata, AlturaLata, VolumeLata;

            Console.WriteLine("Cálculo de volume de lata de óleo");


            Console.WriteLine("Digite diâmeto da lata (em cm): ");
            RaioLata = double.Parse(Console.ReadLine()) / 2;

            Console.WriteLine("Digite a altura da lata (em cm): ");
            AlturaLata = double.Parse(Console.ReadLine());


            VolumeLata = Math.PI * RaioLata * RaioLata * AlturaLata;

            Console.WriteLine(" O volume da lata é de " + VolumeLata + "cm³");
            Console.ReadLine();
        }
    }
}
