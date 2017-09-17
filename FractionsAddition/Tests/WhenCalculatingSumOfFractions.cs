using FractionAddition.ConsoleApp;
using Xunit;

namespace Tests
{
    public class WhenCalculatingSumOfFractions
    {
        [Fact]
        public void AdditionFractionsWithEqualDenominatorsReturnsResultedFraction()
        {
            var firstFraction = new Fraction("1/4");
            var secondFraction = new Fraction("2/4");

            var resultFraction = firstFraction + secondFraction;

            Assert.Equal(3, resultFraction.Numerator);
            Assert.Equal(4, resultFraction.Denominator);
        }

        [Fact]
        public void AdditionFractionWithDifferenceDenominatorsReturnsResultedFraction()
        {
            var firstFraction = new Fraction("1/2");
            var secondFraction = new Fraction("1/3");
            var additionOperation = new AdditionOperation();

            var resultFraction = additionOperation.Execute(firstFraction, secondFraction);

            Assert.Equal(5, resultFraction.Numerator);
            Assert.Equal(6, resultFraction.Denominator);
        }
    }
}