using System;
using FractionCalculator.Calculator.Objects;

namespace FractionCalculator.Calculator
{
    public class FractionCalculator : IFractionCalculator
    {
        public Fraction Add(Fraction a, Fraction b)
        {
            var lowestCommonMultiple = LowestCommonMultiple(a.Denominator, b.Denominator);

            return new Fraction(
                a.Numerator*lowestCommonMultiple/a.Denominator +
                b.Numerator*lowestCommonMultiple/b.Denominator,
                lowestCommonMultiple);

            //return OptimizeFraction(
            //    a.Numerator*lowestCommonMultiple/a.Denominator +
            //    b.Numerator*lowestCommonMultiple/b.Denominator,
            //    lowestCommonMultiple);
        }

        public Fraction Sub(Fraction a, Fraction b)
        {
            var temp = new Fraction(-b.Numerator, b.Denominator);
            return Add(a, temp);
        }

        public Fraction Mul(Fraction a, Fraction b)
        {
            throw new NotImplementedException();
        }

        public Fraction Div(Fraction a, Fraction b)
        {
            throw new NotImplementedException();
        }
        
        private static int LowestCommonMultiple(int a, int b)
        {
            return a/GreatestCommonDivisor(a, b)*b;
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a%b;
                a = temp;
            }

            return Math.Abs(a);
        }

        private static Fraction OptimizeFraction(int numerator, int denominator)
        {
            var gcd = GreatestCommonDivisor(numerator, denominator);
            numerator = numerator / gcd;
            denominator = denominator / gcd;

            if ((numerator < 0) && (denominator < 0))
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }

            if (denominator < 0)
            {
                numerator = -(numerator);
                denominator = Math.Abs(denominator);
            }

            return new Fraction(numerator, denominator);
        }
    }
}