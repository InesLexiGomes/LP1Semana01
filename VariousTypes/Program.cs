using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            ulong ul = 1UL;
            uint hex = 0x10U;
            int bin = 0b1111100;

            Console.WriteLine($"{i} is an int.");
            Console.WriteLine($"{ul} is an ulong.");
            Console.WriteLine($"{hex} is the value of an hexadecimal uint");
            Console.WriteLine($"{bin} is the value of a binary int");
        }
    }
}
