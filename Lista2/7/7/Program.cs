using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Celsius, Fahrenheit;

            Console.WriteLine("Conversor de temperatura: Graus Fahrenheit -> Graus Celsius");


            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            Fahrenheit = double.Parse(Console.ReadLine());

            Celsius = (Fahrenheit - 32) * 5 / 9;

            Console.WriteLine(" A medida convertida é " + Celsius + "ºC");
            Console.ReadLine();
        }
    }
}
