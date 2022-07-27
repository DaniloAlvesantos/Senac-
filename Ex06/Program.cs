using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1, name2, sex1, sex2;
            Console.WriteLine("Type your name: ");
            name1 = Console.ReadLine();
            Console.WriteLine("Type your sex: ");
            sex1 = Console.ReadLine();

            Console.WriteLine("Type a nother name: ");
            name2 = Console.ReadLine();
            Console.WriteLine("Type the sex: ");
            sex2 = Console.ReadLine();

            Console.WriteLine();
            if (sex1 == "m" ^ sex2 == "m")
                Console.WriteLine(name1 + " dence with " + name2);
            else
                Console.WriteLine(name1 + " not dance with " + name2);
        }
    }
}
