using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram.cs
{
    class Program
    {
        static void Monogram(char a, char b, char c)
        {
            Console.WriteLine("** {0}.{1}.{2}. **", a, b, c);
        }

        static void Main(string[] args)
        {
            char f1 = 'B', m1 = 'C', l1 = 'R', f2 = 'M', m2 = 'M', l2 = 'O';

            Monogram(f1, m1, l1);
            Monogram(f2, m2, l2);
        }
    }
}