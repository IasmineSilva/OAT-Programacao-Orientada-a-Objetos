using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 100; x <= 200; x++)
            {
                if (x % 2 == 1)
                {
                    Console.WriteLine(x);
                    Console.ReadLine();
                }
            }
        }
    }
}
