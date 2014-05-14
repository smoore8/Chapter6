using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse4.cs
{
    class Program
    {
        public static void Reverse(ref int w,ref int x, ref int y, ref int z)
        {
            int temp = w;
            int temp2 = x;
            w = z;
            z = temp;
            x = y;
            y = temp2;


        }

        static void Main(string[] args)
        {
            int w = 0, x = 1, y = 2, z = 3;
            Reverse(ref w, ref x, ref y, ref z);

            Console.Write(w);
            Console.Write(x);
            Console.Write(y);
            Console.Write(z);
        }
    }
}