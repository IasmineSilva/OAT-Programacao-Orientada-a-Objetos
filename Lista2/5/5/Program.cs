using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double VelocidadeMedia, TempoGasto, Autonomia = 12;
            double Distancia, LitrosUsados;

            Console.WriteLine("Programa de cálculo da quantidade de litros de combustível gasta em uma viagem");
            Console.WriteLine("--------------------------------------------------------------------------------");


            Console.WriteLine("Digite o tempo que você gastou em sua viagem (horas): ");
            TempoGasto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Velocidade Média em que você fez o percurso (Km/h): ");
            VelocidadeMedia = double.Parse(Console.ReadLine());


            Distancia = VelocidadeMedia * TempoGasto;
            LitrosUsados = Distancia / Autonomia;


            Console.WriteLine("Resultados:");
            Console.WriteLine("Velocidade média = " + VelocidadeMedia + " Km/h");
            Console.WriteLine("Tempo gasto = " + TempoGasto + " horas");
            Console.WriteLine("Distancia Percorrida = " + Distancia + " Km");
            Console.WriteLine("Quantidade de Combustível utilizado: " + LitrosUsados + " litros");
            Console.ReadLine();
        }
    }
}
