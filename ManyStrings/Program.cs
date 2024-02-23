using System;
using System.Text; 

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // numeric variables
            double xx = 1.23456;
            int ii = 19;

            // char variables
            char w = '\u2640';
            char s = '\u2704';

            // string variables
            string l = $"me when {w} and I go {s}";
            string c = "String " + "concatenada :3 " + l;
            string d = $"Me when {c}";

            // console writing
            Console.WriteLine(l);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");
            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");

            // ex 5 because I thought the other ones would be for 4 :3
            string yippee = "Yippee";
            string yippeeSqr = yippee + " " + yippee;
            string yippeeCool = $"{yippee} {yippee} but cool.";

            Console.WriteLine(yippee);
            Console.WriteLine(yippeeSqr);
            Console.WriteLine(yippeeCool);

        }
    }
}
