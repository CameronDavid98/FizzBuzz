using FizzBuzz.Calculators;
using FizzBuzz.Calculators.Interfaces;
using System;

namespace FizzBuzz
{
    class Program
    {
        private static ICalculator _fizzbuzzCal;

        static void Main(string[] args)
        {
            _fizzbuzzCal = new FizzBuzzCalculator();

            for (int i = 1; i <= 100; i++)
            {
                var result = _fizzbuzzCal.Calculate(i);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
