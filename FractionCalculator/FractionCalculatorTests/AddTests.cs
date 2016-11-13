using FractionCalculator.Calculator.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionCalculator.FractionCalculatorTests
{
    [TestClass]
    public class AddTests : BaseTest
    {
        [TestMethod]
        public void CanAddTest()
        {
            // arrange
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(1, 2);

            // act
            var result = FractionCalculator.Add(f1, f2);

            // assert
            Assert.AreEqual(2, result.Numerator);
            Assert.AreEqual(2, result.Denominator);
        }

        [TestMethod]
        public void AddWithZeroNumeratorTest()
        {
            // arrange
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(0, 2);

            // act
            var result = FractionCalculator.Add(f1, f2);

            // assert
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(2, result.Denominator);
        }

        [TestMethod]
        public void AddBothNumeratorsAreZeroTest()
        {
            // arrange
            var f1 = new Fraction(0, 1);
            var f2 = new Fraction(0, 1);

            // act
            var result = FractionCalculator.Add(f1, f2);

            // assert
            Assert.AreEqual(0, result.Numerator);
            Assert.AreEqual(1, result.Denominator);
        }

        [TestMethod]
        public void AddImproperFractionTest()
        {
            var f1 = new Fraction(4, 2);
            var f2 = new Fraction(8, 5);

            var result = FractionCalculator.Add(f1, f2);

            Assert.AreEqual(36, result.Numerator);
            Assert.AreEqual(10, result.Denominator);
        }

        [TestMethod]
        public void AddFractionsWithDifferentDenominatorsTest()
        {
            var f1 = new Fraction(2, 6);
            var f2 = new Fraction(4, 12);

            var result = FractionCalculator.Add(f1, f2);
            Assert.AreEqual(8, result.Numerator);
            Assert.AreEqual(12, result.Denominator);
        }

        [TestMethod]
        public void AddNegativeFractionsTest()
        {
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(-1, 2);

            var result = FractionCalculator.Add(f1, f2);
            Assert.AreEqual(0, result.Numerator);
            Assert.AreEqual(2, result.Denominator);
        }
    }
}
