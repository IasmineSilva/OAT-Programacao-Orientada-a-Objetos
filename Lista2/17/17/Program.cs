using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Numero;

            Console.WriteLine("Verificador de número");


            Console.WriteLine("Digite o primeiro número:  ");
            Numero = int.Parse(Console.ReadLine);



            if (Numero >= 0 && Numero <= 9)
            {
                Console.WriteLine("Valor válido.");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
    }
}
