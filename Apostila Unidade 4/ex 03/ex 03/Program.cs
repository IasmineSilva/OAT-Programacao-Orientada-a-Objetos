using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pop, filhos, total_filhos = 0, i, y = 1;
            float sal, total_sal = 0, media_sal, media_filhos, maior_sal = 0, perc_sal;

            Console.WriteLine("Qual a populacao da cidade..: ");
            pop = int.Parse(Console.ReadLine());

            for (i = 1; i <= pop; i++)
            {
                Console.WriteLine ("Qual o seu salario.........: R$ ");
                sal = float.Parse(Console.ReadLine());
                Console.WriteLine ("Qual a quantia de filhos...: ");
                filhos = int.Parse(Console.ReadLine());

                
                total_sal = sal + total_sal;
               
                total_filhos = total_filhos + filhos;
               
                if (maior_sal < sal)
                {
                    maior_sal = sal;
                }
              
                if (sal <= 1500)
                {
                    perc_sal = (y * 100) / pop;
                    y++;
                }
            }
            
            media_sal = total_sal / pop;
            
            media_filhos = total_filhos / pop;

            Console.WriteLine ("A media do salario da populacao eh R$ %.2f",+  media_sal);
            Console.WriteLine ("A media do numero dos filhos eh %.1f", + media_filhos);
            Console.WriteLine ("O maior salario eh R$ %.2f", + maior_sal);
            Console.WriteLine ("A percentagem das pessoas com salarios ate R$ 240,00 eh %.1f%% " +  perc_sal);
        }
    }
}
