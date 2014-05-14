using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToYards.cs
{
    class Program
    {
        public static void totalYards(int inches)
        {
            int feet, inch, yard;
            feet = inches / 12;
            yard = feet / 3;
            inch = inches % 12;
            Console.WriteLine("{0} Yards {1} Feet and {2} Inches", yard, feet, inch);
        }
        static void Main(string[] args)
        {
            int inches = 100;
            totalYards(inches);
        }
    }
}