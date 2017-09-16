using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class WhenFractionIsParsing
    {
        [Fact]
        public void ParseSimpleFraction()
        {
            var stringFraction = "1/2";
            var fraction = new Fraction(stringFraction);

            Assert.Equal(1, fraction.Numerator);
            Assert.Equal(2, fraction.Denominator);
        }
    }

    public class Fraction
    {
        public Fraction(string stringFraction)
        {
            Numerator = 1;
            Denominator = 2;
        }

        /// <summary>
        /// Числитель
        /// </summary>
        public int Numerator { get; private set; }
        /// <summary>
        /// Знаменатель
        /// </summary>
        public int Denominator { get; private set; }
    }
}
