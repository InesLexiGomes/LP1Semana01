using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int values
            int i = 12;
            ulong ul = 1UL;
            uint hex = 0x10U;
            int bin = 0b1111100;

            //Writing integer values to console
            Console.WriteLine($"{i} is an int.");
            Console.WriteLine($"{ul} is an ulong.");
            Console.WriteLine($"{hex} is the value of an hexadecimal uint");
            Console.WriteLine($"{bin} is the value of a binary int");

            //Char values
            char f = '\u2640';
            char c = '\u2020';
            char t = '\u2122';

            //Writing character and value
            Console.WriteLine($"'\\u2640' is the value of {f}.");
            Console.WriteLine($"'\\u2020' is the value of {c}.");
            Console.WriteLine($"'\\u2122' is the value of {t}.");
        }
    }
}
