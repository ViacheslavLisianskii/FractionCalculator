using System;

namespace FractionCalculator.Calculator.Objects
{
    public class Fraction
    {
        public Fraction(int numerator, int denominator = 1)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be assigned a Zero value");

            if (denominator < 0)
            {
                Numerator = -numerator;
                Denominator = -denominator;
                return;
            }

            Numerator = numerator;
            Denominator = denominator;
        }
        
        public int Numerator { get; set; }

        public int Denominator { get; set; }
    }
}