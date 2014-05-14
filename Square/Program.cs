using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Square.cs
{
    class Square
    {
        public static void Squared(ref int a)
        {
            a = a * a;

            Console.WriteLine("The number squared: {0}", a);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            n = Convert.ToInt32(input);

            Squared(ref n);

            Console.WriteLine("The number squared: {0}", n);
        }
    }
}