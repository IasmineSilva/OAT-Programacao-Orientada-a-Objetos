using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Altura, PesoIdeal;
            char Sexo = 'n';

            Console.WriteLine("Digite sua altura (em metros): ");
            Altura = double.Parse(Console.ReadLine());

            while (Sexo != 'm' && Sexo != 'M' && Sexo != 'h' && Sexo != 'H')
            {

                Console.WriteLine("Digite H ou M para especificar o sexo: ");
                Sexo = char.Parse(Console.ReadLine());

                switch (Sexo)
                {
                    case 'h':
                    case 'H':
                        PesoIdeal = (72.7 * Altura) - 58;
                        Console.WriteLine("Seu peso ideal é de: " + PesoIdeal + " kg.");
                        break;
                    case 'm':
                    case 'M':
                        PesoIdeal = (62.1 * Altura) - 44.7;
                        Console.WriteLine("Seu peso ideal é de: " + PesoIdeal + " kg.");
                        break;
                    default:
                        Console.WriteLine("Não é M");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
