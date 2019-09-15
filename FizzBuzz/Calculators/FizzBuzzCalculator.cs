using FizzBuzz.Calculators.Interfaces;

namespace FizzBuzz.Calculators
{
    public class FizzBuzzCalculator : ICalculator
    {
        public string Calculate(int value)
        {
            if (IsMultipleOf3(value) && IsMultipleOf5(value))
            {
                return "FizzBuzz";
            }
            else if (IsMultipleOf3(value))
            {
                return "Fizz";
            }
            else if (IsMultipleOf5(value))
            {
                return "Buzz";
            }
            else
            {
                return value.ToString();
            }
        }

        private bool IsMultipleOf3(int value)
        {
            return value % 3 == 0;
        }

        private bool IsMultipleOf5(int value)
        {
            return value % 5 == 0;
        }
    }
}
