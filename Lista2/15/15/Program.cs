using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PrimeiraNota, SegundaNota, TerceiraNota, QuartaNota, RecuperacaoNota, Media;
            bool Aprovacao = false;

            Console.WriteLine("Verificador de notas");


            Console.WriteLine("Digite a primeira nota:  ");
            PrimeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:  ");
            SegundaNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:  ");
            TerceiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota:  ");
            QuartaNota = double.Parse(Console.ReadLine());


            Media = (PrimeiraNota + SegundaNota + TerceiraNota + QuartaNota) / 4;

            if (Media >= 7) Aprovacao = true;
            else
            {
                Console.WriteLine("O aluno ficou de recuperação, digite a nota: ");
                RecuperacaoNota = double.Parse(Console.ReadLine());
                Media = (Media + RecuperacaoNota) / 2;
                if (Media >= 7) Aprovacao = true;
            }

            if (Aprovacao == true)
            {
                Console.WriteLine("O Aluno foi aprovado com a média " + Media);
            }
            else
            {
                Console.WriteLine("O Aluno foi reprovado com a média " + Media);

            }
            Console.ReadLine();
        }
    }
}
