using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PrimeiroNumero, SegundoNumero, Resultado;
            int Menu;
            Console.WriteLine("Menu Calculadora");


            Console.WriteLine("Digite uma das operações a seguir:\n\t1 - Adição\n\t2 - Subtração\n\t3 - Multiplicação\n\t4 - Divisão\n");
            Menu = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o primeiro numero: ");
            PrimeiroNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            SegundoNumero = double.Parse(Console.ReadLine());


            switch (Menu)
            {
                case 1:
                    Resultado = PrimeiroNumero + SegundoNumero;
                    Console.WriteLine("Resultado: "  + Resultado);
                    break;
                case 2:
                    Resultado = PrimeiroNumero - SegundoNumero;
                    Console.WriteLine( "Resultado: " + Resultado);
                    break;
                case 3:
                    Resultado = PrimeiroNumero * SegundoNumero;
                    Console.WriteLine("Resultado : "  + Resultado);
                    break;
                case 4:
                    Resultado = PrimeiroNumero / SegundoNumero;
                    Console.WriteLine( "Resultado: " + Resultado);
                    break;
                default:
                    Console.WriteLine("opção inválida!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
