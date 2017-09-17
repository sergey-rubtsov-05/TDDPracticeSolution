using System;
using FractionAddition.ConsoleApp;
using Xunit;

namespace Tests
{
    public class WhenFractionIsParsing
    {
        [Fact]
        public void ParseSimpleFractionFromStringWithSolidus()
        {
            var stringFraction = "1/2";

            var fraction = new Fraction(stringFraction);

            Assert.Equal(1, fraction.Numerator);
            Assert.Equal(2, fraction.Denominator);
        }

        [Fact]
        public void ParseSimpleFractionFromStringWithIntValue()
        {
            var stringFraction = "2";

            var fraction = new Fraction(stringFraction);

            Assert.Equal(2, fraction.Numerator);
            Assert.Equal(1, fraction.Denominator);
        }

        [Fact]
        public void ParseFractionFromStringWith0InDenominatorThrowsException()
        {
            var stringFraction = "2/0";

            Action action = () => new Fraction(stringFraction);

            var exception = Assert.Throws<Exception>(action);
            Assert.Equal("Denominator cannot be null", exception.Message);
        }
    }
}