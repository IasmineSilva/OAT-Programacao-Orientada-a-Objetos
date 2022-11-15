using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linha;
            double media_aproveitamento;
            int numero;
            int nota1, nota2, nota3;
            string avaliacao_final;

            Console.Write("Introduza o numero do aluno = ");
            linha = Console.ReadLine();
            numero = Int32.Parse(linha);

            Console.Write("Introduza a nota1 = ");
            linha = Console.ReadLine();
            nota1 = Int32.Parse(linha);

            Console.Write("Introduza a nota2 = ");
            linha = Console.ReadLine();
            nota2 = Int32.Parse(linha);

            Console.Write("Introduza a nota3 = ");
            linha = Console.ReadLine();
            nota3 = Int32.Parse(linha);

            media_aproveitamento = (nota1 + (2 * nota2) + (3 * nota3)) / 7;

            if (media_aproveitamento >= 90)
            {
                avaliacao_final = "A - Aprovado";
            }
            else
            {
                if (media_aproveitamento >= 75 && media_aproveitamento < 90)
                {
                    avaliacao_final = "B - Aprovado";
                }
                else
                {
                    if (media_aproveitamento >= 60 && media_aproveitamento < 75)
                    {
                        avaliacao_final = "C - Aprovado";
                    }
                    else
                    {
                        if (media_aproveitamento >= 40 && media_aproveitamento < 60)
                        {
                            avaliacao_final = "D - Reprovado";
                        }
                        else
                        {
                            avaliacao_final = "E - Reprovado";
                        }
                    }
                }
            }

            Console.WriteLine("Dados do Aluno número: " + numero);
            Console.WriteLine("Nota1= " + nota1 + " Nota2= " + nota2 + " Nota3= " + nota3 + " = ");
            Console.WriteLine("Media de aproveitamento= " + media_aproveitamento + " Avaliação final= " + avaliacao_final);
            Console.ReadLine();
        }
    }
}
