using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code;
            Console.WriteLine("Entre com o codigo de acesso");
            code = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (code == 1 || code == 2 || code == 3)
            {
                if (code == 1)
                    Console.WriteLine("um");
                if (code == 2)
                    Console.WriteLine("dois");
                if (code == 3)
                    Console.WriteLine("três");
            }
            else
            {
                Console.WriteLine("Codigo invalido");
            }
        }
    }
}
