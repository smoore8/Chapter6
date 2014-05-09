using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram
{
    class Program
    {
        public static void ConsoleWriteLineDupe(string let, params object[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                let = let.Replace("{" + i + "}", parameters[i].ToString());
            }

            Console.WriteLine(let);
        }


        public static void Monogram(char a, char b, char c, char d, char e, char f)
        {

            Console.WriteLine("** {0}.{1}.{2}. **", a, b, c);

            Console.WriteLine("** {0}.{1}.{2}. **", d, e, f);
        }

        static void Main(string[] args)
        {
            char f1 = 'J', m1 = 'D', l1 = 'B', f2 = 'M', m2 = 'Q', l2 = 'T';


            Monogram(f1, m1, l1, f2, m2, l2);

        }
    }
}
