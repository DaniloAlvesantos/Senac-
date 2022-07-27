using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Entre com um valor ");
            number = int.Parse(Console.ReadLine());

            if (number >= 20 && number <= 90)
                Console.WriteLine("O valor está entre 20 e 90");
            else
                Console.WriteLine("O valor não está entre 20 a 90");
        }
    }
}
