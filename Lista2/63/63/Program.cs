using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(Verifica(numero));
        }
        public static String Verifica(int numero)
        {
            if (numero % 2 == 0) return "PAR";
            else return "ÍMPAR";
        }
        
    }
}
