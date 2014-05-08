using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers2
{
    class Program
    {

        public static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }


        public static void Difference(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public static int Product(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            int q = 30, t = 39;

            Sum(q, t);
            Difference(q, t);

            int result = Product(q, t);

            Console.WriteLine(result);


        }
    }
}