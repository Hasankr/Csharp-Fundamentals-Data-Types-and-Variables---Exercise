using System;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            int snowballQuality = 0;
            BigInteger bestSnowball = int.MinValue;
            string bestSnowBallFormula = "";

            for (int i = 0; i < N; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                BigInteger currentSnowBallValue = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(currentSnowBallValue, snowballQuality);
                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    bestSnowBallFormula = $"{ snowballSnow} : { snowballTime} = { snowballValue} ({ snowballQuality})";
                }
            }
            Console.WriteLine(bestSnowBallFormula);
        }
    }
}
