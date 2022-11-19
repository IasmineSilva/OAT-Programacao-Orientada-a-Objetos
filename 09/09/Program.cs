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
            char sexo = char.Parse(Console.ReadLine());

            Console.Write("Escreva aqui sua altura:");
            double altura = double.Parse(Console.ReadLine());



            double formula;

            if (sexo == 'm')

            {
                formula = (72.2 * altura) - 58;
                Console.WriteLine("sexo:" + sexo + "  o seu peso ideal é: " + formula);
                Console.ReadLine();
            }

            else if (sexo == 'f')

            {
                formula = (62.1 * altura) - 44.7;
                Console.WriteLine("Sexo:" + sexo + "o seu peso ideal é: " + formula);
                Console.ReadLine();
            }
        }
    }
}
