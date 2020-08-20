using System;

namespace HW_Random_Generator
{
    public class RandomGenerator : IRandomGenerator
    {
        public int[] GetRandomNumbers(int count, int minValue, int maxValue)
        {
            var rand = new Random();
            var randNumbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                randNumbers[i] = rand.Next(minValue, maxValue + 1);
            }

            return randNumbers;
        }
    }
}
