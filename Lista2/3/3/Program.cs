using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para ler a comissão");

            int IdVendedor, IdPeca;
            double PrecoPeca, Quantidade, ValorComissao, PorcentagemComissao = 0.05;

            Console.WriteLine("Digite a identificação do vendedor: ");
            IdVendedor = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o ID da Peça: ");
            IdPeca = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço unitário da peça: ");
            PrecoPeca = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite a quantidade de peças vendidas: ");
            Quantidade = double.Parse(Console.ReadLine());


            ValorComissao = (PrecoPeca * Quantidade) * PorcentagemComissao;

            Console.WriteLine("O valor da comissão é de ", +ValorComissao /  );
            Console.ReadLine();
        }
    }
}
