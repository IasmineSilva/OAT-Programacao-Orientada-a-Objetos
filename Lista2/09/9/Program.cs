using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IdadeAnos, IdadeMeses, IdadeDias, IdadeTotalDias;

            Console.WriteLine("Calculadora de idade em dias");


            Console.WriteLine("Digite os anos: ");
            IdadeAnos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os meses: ");
            IdadeMeses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dias: ");
            IdadeDias = int.Parse(Console.ReadLine());


            IdadeTotalDias = IdadeAnos * 365 + IdadeMeses * 30 + IdadeDias;
            Console.WriteLine("Idade total em dias = " + IdadeTotalDias);
            Console.ReadLine();
        }
    }
}
