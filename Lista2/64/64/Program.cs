using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine ("Digite uma opção: ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CarregarVetor();
                        break;
                    case 2:
                        Console.WriteLine(ListarVetor());
                        break;
                    case 3:
                        Console.WriteLine (ListarParesVetor());
                        break;
                    case 4:
                        Console.WriteLine (ListarImparesVetor());
                        break;
                    case 5:
                        Console.WriteLine (QuantidadeParesNosImparesVetor());
                        break;
                    case 6:
                        Console.WriteLine (QuantidadeImparesNosParesVetor());
                        break;
                    case 7:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine ("Número inválido.");
                        break;
                }
            }
        }
        public static void CarregarVetor()
        {

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine ("Digite o " + (x + 1) + "° número do vetor: ");
                Vetor[x] = 
            }
            Console.WriteLine ("\nVetor carregado com sucesso!\n");
        }
        //2 - Listar Vetor
        public static String ListarVetor()
        {
            String ListaVetor = "Valores do vetor:\n";
            for (int x = 0; x < 10; x++)
            {
                ListaVetor += "\t" + Vetor[x] + "\n";
            }
            return ListaVetor;
        }
        //3 - Exibir apenas os números pares do vetor
        public static String ListarParesVetor()
        {
            String ListaVetor = "Valores do vetor:\n";
            for (int x = 0; x < 10; x++)
            {
                if (Vetor[x] % 2 == 0)
                {
                    ListaVetor += "\t" + Vetor[x] + "\n";
                }
            }
            return ListaVetor;
        }
        
        public static String ListarImparesVetor()
        {
            String ListaVetor = "Valores do vetor:\n";
            for (int x = 0; x < 10; x++)
            {
                if (Vetor[x] % 2 == 1)
                {
                    ListaVetor += "\t" + Vetor[x] + "\n";
                }
            }
            return ListaVetor;
        }
        public static int QuantidadeParesNosImparesVetor()
        {
            int quantidade = 0;
            for (int x = 1; x < 10; x = x + 2)
            {
                if (Vetor[x] % 2 == 0)
                {
                    quantidade++;
                }
            }
            return quantidade;
        }
        public static int QuantidadeImparesNosParesVetor()
        {
            int quantidade = 0;
            for (int x = 0; x < 10; x = x + 2)
            {
                if (Vetor[x] % 2 == 1)
                {
                    quantidade++;
                }
            }
            return quantidade;
        }
    }
}
