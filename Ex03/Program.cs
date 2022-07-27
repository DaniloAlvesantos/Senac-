using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, r;

            Console.WriteLine("Digite o 1º valor");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor");
            b = int.Parse(Console.ReadLine());

            r = a + b;

            Console.WriteLine();
            if(r >= 10)
                Console.WriteLine("Resultado de {1} + {2} = {0}",r, a, b);
        }
    }
}
