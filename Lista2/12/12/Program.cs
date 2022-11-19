using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero, ModuloNumero;

            Console.WriteLine("Módulo de Número");


            Console.WriteLine("Digite um número inteiro:  ");
            Numero = int.Parse(Console.ReadLine());


            ModuloNumero = (Numero < 0) ? ModuloNumero = Numero * (-1) : Numero;

            Console.WriteLine("O módulo do número é " + ModuloNumero + "");
            Console.ReadLine();
        }
    }
}
