using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, x;
            Console.WriteLine("Type one value: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Type another value: ");
            b= float.Parse(Console.ReadLine());
            Console.WriteLine("Type the last value: ");
            c= float.Parse(Console.ReadLine());
            Console.WriteLine();

            if (!(c > 5))
                x = (a + b) * c;
            else
                x = (b - a) * c;
            Console.WriteLine("O resultado de X equivale a: " + x);
        }
    }
}
