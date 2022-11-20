using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            bool acertou = false;
            int chute, QTDtentativas = 0;

            int numero = gerador.Next(101);

            while (acertou == false)
            {
                Console.Write("Digite um número entre 0 a 100: ");
                chute = Convert.ToInt32(Console.ReadLine());
                QTDtentativas++;
                if (chute == numero)
                {
                    Console.WriteLine($"Você acertou em {QTDtentativas}  tentativas!");
                    acertou = true;
                }
                else if (chute > numero)
                {
                    Console.WriteLine("O número é menor.");
                }
                else
                {
                    Console.WriteLine("O número é maior.");
                }
                Console.ReadLine();
            }


        }
    }
}
