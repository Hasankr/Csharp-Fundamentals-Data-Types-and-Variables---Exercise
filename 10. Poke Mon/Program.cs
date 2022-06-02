using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int startingPower = power;
            int countPokedTargets = 0;
            while (power >= distance)
            {
                power -= distance;
                countPokedTargets++;
                if (startingPower * 0.5 == power && exhaustion > 0)
                {
                    power /= exhaustion;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(countPokedTargets);

        }
    }
}
