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
            decimal imc = 0;
            decimal peso = 0;
            decimal altura = 0;
            Console.WriteLine("Entre com sua altura: ");
            altura = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o peso");
            peso = decimal.Parse(Console.ReadLine());
            imc = peso / (altura * altura);

            Console.WriteLine("O IMC é: " + imc);
            if (imc < decimal.Parse("18,5"))
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc > decimal.Parse("18,50") && imc < 25)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine("Acima do Peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
            Console.ReadLine();
        }
    }
}
