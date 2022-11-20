using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0, B = 0, Numero;
            Console.WriteLine("Organizador de números"); 

            do
            {
                Console.WriteLine("Digite um número, digite 0 para sair: ");
                Numero = double.Parse(Console.ReadLine());
                if (Numero > 0)
                {
                    A += Numero;
                    Console.WriteLine("Numero armazenado em A");
                }
                else if (Numero < 0)
                {
                    B += Numero;
                    Console.WriteLine("Numero armazenado em B");
                }
            } while (Numero != 0);
            Console.WriteLine("A= %2f B= %2f ", A, B);
            Console.ReadLine();
        }
    }
}
