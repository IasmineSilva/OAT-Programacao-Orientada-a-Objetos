using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCompraVista = 0;
            double valorCompraPrazo = 0;
            double valorCompraTotal = 0;
            string tipoCompra = string.Empty;
            double valorCompra = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite o valor da compra");
                valorCompra = double.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite V para compras à vista!");
                    Console.WriteLine("Digite P para compras à prazo!");
                    tipoCompra = Console.ReadLine();

                    if (tipoCompra != "V" || tipoCompra != "P")
                        Console.WriteLine("Digite V ou P");

                } while (tipoCompra != "V" && tipoCompra != "P");

                if (tipoCompra == "V")
                    valorCompraVista += valorCompra;

                if (tipoCompra == "P")
                    valorCompraPrazo += valorCompra;
            }

            valorCompraTotal = valorCompraPrazo + valorCompraVista;

            Console.WriteLine("O valor total de compras a prazo foi de: {0}", valorCompraPrazo);
            Console.WriteLine("O valor total de compras a vista foi de: {0}", valorCompraVista);
            Console.WriteLine("O valor total de compras a prazo foi de: {0}", valorCompraTotal);
            Console.ReadLine();
        }
    }
}
