using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int numElementos = 0;
            int somaDosNumeros = 0;
            int mediaDosNumeros = 0;
            int menor = 0, maior = 0;

            int[] meuArray;

            Console.WriteLine("Infome o numero de elementos:");
            numElementos = Convert.ToInt32(Console.ReadLine());

           
            meuArray = new int[numElementos];
           
            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine("Informe o º número");
                meuArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numElementos; i++)
            {
                
                somaDosNumeros += meuArray[i];
            }

            mediaDosNumeros = (somaDosNumeros / meuArray.Length);

           
            for (int i = 0; i < numElementos; i++)
            {
                if (i == 0)
                {
                    menor = meuArray[0];
                    maior = meuArray[0];
                }

                if (meuArray[i] < menor)
                {

                    menor = meuArray[i];

                }
                else if (meuArray[i] > maior)
                {
                    maior = meuArray[i];
                }

            }

            
            Console.WriteLine(new string('=', 50));
            Console.WriteLine( /* RESULTADO FINAL */ );
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("A média é:{0}", mediaDosNumeros);
            Console.WriteLine("O menor número é:" + menor);
            Console.WriteLine("O maior número é:" + maior);


            Console.Read();

        }
    }
}
