using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacao_dolar, valor_dolar, valor_real;

            Console.WriteLine("Conversor de Moeda");

            Console.WriteLine("Digite a cotação do dolar");
            cotacao_dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em dolar:");
            valor_dolar = double.Parse(Console.ReadLine());

            valor_real = cotacao_dolar * valor_dolar;

            Console.WriteLine("O valor em reais é: " + valor_real);
            Console.ReadLine();
        }
    }
    
}
