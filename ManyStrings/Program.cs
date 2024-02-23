using System;
using System.Text; 

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char w = '\u2640';
            char s = '\u2704';

            string l = $"me when {w} and I go {s}";
            string c = "String " + "concatenada :3 " + l;
            string d = $"Me when {c}";

            Console.WriteLine(l);
            Console.WriteLine(c);
            Console.WriteLine(d);

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
