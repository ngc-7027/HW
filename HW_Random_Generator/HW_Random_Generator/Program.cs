using System;

namespace HW_Random_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var randGenerator = new RandomGenerator();
            var randNumbers = randGenerator.GetRandomNumbers(2, 1, 7);

            foreach (var number in randNumbers)
            {
                Console.WriteLine(number);
            }

            Console.Read();
        }
    }
}
