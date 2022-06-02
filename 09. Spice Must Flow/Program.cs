using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CONSUME_BY_WORKERS = 26;
            const int MINIMAL_SPICES_TO_GATHER = 100;
            const int DAILY_DECREASE = 10;

            int countOfSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCounter = 0;
            while (countOfSpices >= MINIMAL_SPICES_TO_GATHER)
            {
                totalConsumed += countOfSpices - CONSUME_BY_WORKERS;
                countOfSpices -= DAILY_DECREASE;
                daysCounter++;
                if (countOfSpices < MINIMAL_SPICES_TO_GATHER)
                {
                    totalConsumed -= CONSUME_BY_WORKERS;
                }
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalConsumed);
        }
    }
}
