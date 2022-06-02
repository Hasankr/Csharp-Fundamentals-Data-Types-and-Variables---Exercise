using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());
            int finalSum = 0;
            while (numInput != 0)
            {
                int lastdigit = numInput % 10;
                finalSum += lastdigit;
                numInput /= 10;
                
            }
            Console.WriteLine(finalSum);
        }
    }
}
