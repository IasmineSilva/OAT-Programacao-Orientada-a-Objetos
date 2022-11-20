using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade;
            bool parar = false;
            char letra;
            String categoria;

            do
            {
                do
                {
                    Console.WriteLine ("Digite a idade do nadador: ");
                    idade = double.Parse(Console.ReadLine());
                    if (idade < 5) Console.WriteLine ("Idade inválida.");
                } while (idade < 5);

                Console.WriteLine();

                if (idade >= 5 && idade < 8) categoria = "Infantil A";
                else if (idade >= 8 && idade < 12) categoria = "Infantil B";
                else if (idade >= 12 && idade < 14) categoria = "Juvenil A";
                else if (idade >= 14 && idade < 18) categoria = "Juvenil B";
                else categoria = "Adultos";


                Console.WriteLine ("A categoria é: " + categoria);

                Console.WriteLine ("\nDeseja encerrar o programa? (s/N) ");
                letra = char.Parse(Console.ReadLine());
                if (letra == 's' || letra == 'S')
                {
                    parar = true;
                }

            } while (parar == false);
        }
    }
}
