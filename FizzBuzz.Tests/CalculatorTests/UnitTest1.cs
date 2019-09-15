using FizzBuzz.Calculators;
using FizzBuzz.Calculators.Interfaces;
using NUnit.Framework;

namespace Tests.CalculatorTests
{
    public class Tests
    {
        private ICalculator _fizzbuzzCal;

        [SetUp]
        public void Setup()
        {
            _fizzbuzzCal = new FizzBuzzCalculator();
        }

        [Test]
        public void GivenAMultipleOf3ItShouldReturnFizz()
        {
            var result = _fizzbuzzCal.Calculate(6);
            var expectedResult = "Fizz";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GivenAMultipleOf5ItShouldReturnBuzz()
        {
            var result = _fizzbuzzCal.Calculate(5);
            var expectedResult = "Buzz";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GivenAMultipleOf3And5ItShouldReturnFizzBuzz()
        {
            var result = _fizzbuzzCal.Calculate(15);
            var expectedResult = "FizzBuzz";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GivenANegativeMultipleOf3ItShouldReturnFizz()
        {
            var result = _fizzbuzzCal.Calculate(-3);
            var expectedResult = "Fizz";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GivenANegativeMultipleOf5ItShouldReturnBuzz()
        {
            var result = _fizzbuzzCal.Calculate(-10);
            var expectedResult = "Buzz";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GivenANegativeMultipleOf3And5ItShouldReturnFizzBuzz()
        {
            var result = _fizzbuzzCal.Calculate(-30);
            var expectedResult = "FizzBuzz";

            Assert.AreEqual(expectedResult, result);
        }
    }
}