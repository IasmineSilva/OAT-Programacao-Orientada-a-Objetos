using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool parar = false;
            char letra;

            do
            {
                Console.WriteLine ("Digite um número inteiro: ");
                numero = int.Parse(Console.ReadLine());


                if (numero % 2 == 0)
                {
                    Console.WriteLine ("O número é par.\n");
                }
                else
                {
                    Console.WriteLine( "O número não é par\n");
                }
                if (numero < 0)
                {
                    Console.WriteLine ("O número é negativo\n");
                }
                else
                {
                    Console.WriteLine ("O número é positivo\n");
                }

                Console.WriteLine ("Deseja sair? (s/N)? ");
                letra = char.Parse(Console.ReadLine());
                if (letra == 's' || letra == 'S')
                {
                    parar = true;
                }

            } while (parar == false);
        }
    }
}
