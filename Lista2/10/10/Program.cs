using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PrimeiroNumero, SegundoNumero;
            bool Igual = false, NaoIgual = false, Maior = false, Menor = false, MaiorOuIgual = false, MenorOuIgual = false;

            Console.WriteLine("Mostrando Relacionamentos");


            Console.WriteLine("Digite o primeiro número:  ");
            PrimeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            SegundoNumero = int.Parse(Console.ReadLine());

            if (PrimeiroNumero == SegundoNumero) Igual = true;
            if (PrimeiroNumero != SegundoNumero) NaoIgual = true;
            if (PrimeiroNumero > SegundoNumero) Maior = true;
            if (PrimeiroNumero < SegundoNumero) Menor = true;
            if (PrimeiroNumero >= SegundoNumero) MaiorOuIgual = true;
            if (PrimeiroNumero <= SegundoNumero) MenorOuIgual = true;

            Console.WriteLine("Igual = " + Igual);
            Console.WriteLine("Não Igual = " + NaoIgual);
            Console.WriteLine("Maior = " + Maior);
            Console.WriteLine("Menor = " + Menor);
            Console.WriteLine("Maior ou igual = " + MaiorOuIgual);
            Console.WriteLine("Menor ou igual = " + MenorOuIgual);
            Console.ReadLine();
        }
    }
}
