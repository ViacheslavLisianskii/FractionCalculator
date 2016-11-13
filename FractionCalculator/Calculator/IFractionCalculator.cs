using FractionCalculator.Calculator.Objects;

namespace FractionCalculator.Calculator
{
    public interface IFractionCalculator
    {
        Fraction Add(Fraction a, Fraction b);

        Fraction Sub(Fraction a, Fraction b);

        Fraction Mul(Fraction a, Fraction b);

        Fraction Div(Fraction a, Fraction b);
    }
}
