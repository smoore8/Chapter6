using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent
{
    class Program
    {
        public static int Square(int a)
        {
            a = a * a;

            return (a);
        }
        public static int Cube(int a)
        {
            a = a * a * a;

            return (a);
        }

        static void Main(string[] args)
        {
            String input = Console.ReadLine();

            int n = Convert.ToInt32(input);

            Console.WriteLine(Square(n));
            Console.WriteLine(Cube(n));
        }
    }
}