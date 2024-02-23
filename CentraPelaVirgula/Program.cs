using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            // there will be dots.
            CultureInfo.DefaultThreadCurrentCulture =
            CultureInfo.InvariantCulture;

            // asking the user for inputs.
            Console.WriteLine("Give me 4 real numbers.\n");

            // first input
            string input1 = Console.ReadLine();
            float num1 = float.Parse(input1);

            // second input
            string input2 = Console.ReadLine();
            float num2 = float.Parse(input2);

    	    // third input
            string input3 = Console.ReadLine();
            float num3 = float.Parse(input3);

            // fourth input
            string input4 = Console.ReadLine();
            float num4 = float.Parse(input4);

            // writing values
            Console.WriteLine($"{num1,6:f2}");
            Console.WriteLine($"{num2,6:f2}");
            Console.WriteLine($"{num3,6:f2}");
            Console.WriteLine($"{num4,6:f2}");

        }
    }
}
