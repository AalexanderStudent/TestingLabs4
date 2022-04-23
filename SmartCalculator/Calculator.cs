using System;

namespace SmartCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber+SecondNumber;
        }

        public int Sub()
        {
            return FirstNumber - SecondNumber;
        }

        public int Mult()
        {
            return FirstNumber * SecondNumber;
        }

        public int Div()
        {
            if (FirstNumber == 0)
                throw new DivideByZeroException();
            return FirstNumber / SecondNumber;
        }
    }
}
