using Calculators.Exceptions;
using Calculators;
using FluentAssertions;
using System;
using Xunit;

namespace Test
{
    public class CalculatorTest
    {
        private readonly Calculator _sut;

        public CalculatorTest()
        {
            var gaurd = new CalculatorGaurd();
            _sut = new Calculator(gaurd);
        }

        [Fact]
        public void Add_should_add_two_number_correctly()
        {
            var firstNumber = 2;
            var secondNumber = 3;

            var actual = _sut.Add(firstNumber, secondNumber);

            var expected = firstNumber + secondNumber;
            actual.Should().Be(expected);
        }

        [Fact]
        public void Division_should_divide_properly()
        {
            var firstNumber = 10;
            var secondNumber = 2;

            var actual = _sut.Division(firstNumber, secondNumber);

            var expected = firstNumber / secondNumber;
            actual.Should().Be(expected);
        }

        [Fact]
        public void Division_not_divide_when_secondNumber_equal_zero()
        {
            var firstNumber = 10;
            var secondNumber = 0;

            Func<int> actual = () => _sut.Division(firstNumber, secondNumber);

            actual.Should().ThrowExactly<DivideByZeroInCalculatorException>();
        }
    }
}
