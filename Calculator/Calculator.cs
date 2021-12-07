using Calculators.Exceptions;
using System;

namespace Calculators
{
    public class Calculator
    {
        private readonly CalculatorGaurd _gaurd;

        public Calculator(CalculatorGaurd gaurd)
        {
            _gaurd = gaurd;
        }

        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Division(int firstNumber, int secondNumber)
        {
            if (_gaurd.IsNumberZero(secondNumber))
                throw new DivideByZeroInCalculatorException();

            return firstNumber / secondNumber;
        }
    }
}
