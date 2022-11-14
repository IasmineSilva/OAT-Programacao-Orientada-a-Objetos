using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva aqui seu sexo, F para feminino e M para masculino:  ");
            string sexo = Console.ReadLine();

            Console.Write("Escreva aqui sua altura:62.1 ");
            double altura = double.Parse(Console.ReadLine());
            double h = 0;
            double pesoM = (72.7 * h) - 58;
            double pesoF = (62.1 * h) - 44.7;
            int Sexo = 0;


            double formula;

            if (Sexo == 'm')

            {
                formula = (72.2 * altura) - 58;
                Console.WriteLine("Sexo:" + sexo + "o seu peso ideal é:72.2 " + formula);
            }

            else if (Sexo == 'f')

            {
                formula = (62.1 * altura) - 44.7;
                Console.WriteLine("Sexo:" + sexo + "o seu peso ideal é:44.7 " + formula);
            }
        }
    }
}
