using FractionCalculator.Calculator.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionCalculator.FractionCalculatorTests
{
    [TestClass]
    public class SubTests : BaseTest
    {
        [TestMethod]
        public void CanSubTest()
        {
            // arrange
            var f1 = new Fraction(2, 3);
            var f2 = new Fraction(1, 2);

            // act
            var result = FractionCalculator.Sub(f1, f2);

            // assert
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(6, result.Denominator);
        }

        [TestMethod]
        public void AddWithZeroNumeratorTest()
        {
            // arrange
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(0, 2);

            // act
            var result = FractionCalculator.Sub(f1, f2);

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
            var result = FractionCalculator.Sub(f1, f2);

            // assert
            Assert.AreEqual(0, result.Numerator);
            Assert.AreEqual(1, result.Denominator);
        }
        
        [TestMethod]
        public void SubFractionFromZeroTest()
        {
            // arrange
            var f1 = new Fraction(0, 2);
            var f2 = new Fraction(1, 2);

            // act
            var result = FractionCalculator.Sub(f1, f2);

            // assert
            Assert.AreEqual(-1, result.Numerator);
            Assert.AreEqual(2, result.Denominator);
        }

        [TestMethod]
        public void SubImproperFractionTest()
        {
            // arrange
            var f1 = new Fraction(5, 2);
            var f2 = new Fraction(5, 3);

            // act
            var result = FractionCalculator.Sub(f1, f2);

            // assert
            Assert.AreEqual(5, result.Numerator);
            Assert.AreEqual(6, result.Denominator);
        }

        [TestMethod]
        public void AddFractionsWithDifferentDenominatorsTest()
        {
            // arrange
            var f1 = new Fraction(5, 9);
            var f2 = new Fraction(2, 8);

            // act
            var result = FractionCalculator.Sub(f1, f2);

            // assert
            Assert.AreEqual(22, result.Numerator);
            Assert.AreEqual(72, result.Denominator);
        }

        [TestMethod]
        public void SubNegativeFractionTest()
        {
            // arrange
            var f1 = new Fraction(-1, 2);
            var f2 = new Fraction(-1, 2);

            // act
            var result = FractionCalculator.Sub(f1, f2);

            // assert
            Assert.AreEqual(0, result.Numerator);
            Assert.AreEqual(2, result.Denominator);
        }

        [TestMethod]
        public void SubZeroResultTest()
        {
            // arrange
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(1, 2);

            // act
            var result = FractionCalculator.Sub(f1, f2);

            // assert
            Assert.AreEqual(0, result.Numerator);
            Assert.AreEqual(2, result.Denominator);
        }
    }
}
