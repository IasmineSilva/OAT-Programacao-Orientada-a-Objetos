using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string NovaFrase = "";

            do
            {
                Console.Write("Digite uma frase (limite de 50 caracteres): ");
                frase = Console.ReadLine();

            } while (frase.Length > 50);

            char[] ArrayChars = frase.ToCharArray();

            for (int x = 0; x < ArrayChars.Length; x++)
            {
                if (ArrayChars[x] != ' ')
                {
                    NovaFrase = NovaFrase + ArrayChars[x];
                }
            }
            Console.WriteLine($"Nova frase: {NovaFrase}");
            Console.ReadLine();
        }
    }
}
