using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CODIGO;

            Console.WriteLine("Verificador de Código");


            Console.WriteLine("Digite o Código:  ");
            CODIGO = int.Parse(Console.ReadLine());



            switch (CODIGO)
            {
                case 1:
                    Console.WriteLine("um");
                    break;
                case 2:
                    Console.WriteLine("dois");
                    break;
                case 3:
                    Console.WriteLine("três");
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
    
}
