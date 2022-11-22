using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da base: ");
            double BaseHipotenusa = double.Parse(Console.ReadLine());
            Console.WriteLine ("Digite o tamanho da altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("A hipotenusa é : " + Hipotenusa(BaseHipotenusa, altura));
        }
        public static double Hipotenusa(double Base, double Altura)
        {
            double hipotenusa = (Base * Base) + (Altura * Altura);
            hipotenusa = Math.Sqrt(hipotenusa);
            return hipotenusa;
        }
    }
    
}
