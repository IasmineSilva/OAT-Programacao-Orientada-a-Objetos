using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite F para feminino e M para masculino: ");
            char sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Escreva seu estado civil: ");
            string estado = Console.ReadLine();

            if ((sexo == 'f') && (estado == "casada"))
            {
                Console.WriteLine("Digite quantos anos você tem de casada");
                int casad = int.Parse(Console.ReadLine());
                Console.WriteLine("Seu nome é: {0} seu sexo {1} e você tem {2} anos de casada: ", nome, sexo, casad);
            }
            else
            {
                Console.WriteLine("{0} você está aproveitando a vida", nome);

            }
            Console.ReadLine();
        }
    }
}
