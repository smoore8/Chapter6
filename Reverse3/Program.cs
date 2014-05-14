using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse3
{
    class Program
    {
        public static void reverse(ref int a,ref int b,ref int c)
        {
            int temp = a;
            a = c;
            c = temp;
            a = temp;
        }
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            reverse(ref a,ref b,ref c);

            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
        }
    }
}
