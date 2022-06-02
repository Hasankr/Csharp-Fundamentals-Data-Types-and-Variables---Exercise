using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int n = int.Parse(Console.ReadLine());
            int totalQuantity = CAPACITY;

            
            for (int i = 0; i < n; i++)
            {
                int currliters = int.Parse(Console.ReadLine());
                
                if (totalQuantity - currliters >= 0)
                {
                 
                    totalQuantity -= currliters;
   
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                
            }
            int totalfilledquantity = CAPACITY - totalQuantity;
            Console.WriteLine(totalfilledquantity);
        }
    }
}
