using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            long num3 = long.Parse(Console.ReadLine());
            long num4 = long.Parse(Console.ReadLine());
            long operation1 = num1 + num2;
            long operation2 = operation1 / num3;
            long operation3 = operation2 * num4;
            Console.WriteLine(operation3);
        }
    }
}
