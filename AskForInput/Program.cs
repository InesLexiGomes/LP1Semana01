using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Give me an int.");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);

            // second input
            Console.WriteLine("Give me a float.");
            string input2 = Console.ReadLine();
            float num2 = Convert.ToSingle(input2);

            // result
            Console.WriteLine($"The sum is {num1 + num2}.");
        }
    }
}
