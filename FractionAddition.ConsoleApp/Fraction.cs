using System;

namespace FractionAddition.ConsoleApp
{
    public class Fraction
    {
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public Fraction(string stringFraction)
        {
            var fractionParts = stringFraction.Split('/');
            if (fractionParts.Length == 1)
            {
                Numerator = int.Parse(fractionParts[0]);
                Denominator = 1;
                return;
            }
            Numerator = int.Parse(fractionParts[0]);
            var denominator = int.Parse(fractionParts[1]);
            if (denominator == 0)
            {
                throw new Exception("Denominator cannot be null");
            }
            Denominator = denominator;
        }

        /// <summary>
        ///     Числитель
        /// </summary>
        public int Numerator { get; }

        /// <summary>
        ///     Знаменатель
        /// </summary>
        public int Denominator { get; }

        public static Fraction operator +(Fraction firstFraction, Fraction secondFraction)
        {
            if (firstFraction.Denominator == secondFraction.Denominator)
            {
                var numerator = firstFraction.Numerator + secondFraction.Numerator;
                return new Fraction($"{numerator}/{firstFraction.Denominator}");
            }

            var leastCommonMultiple =
                CalculateLeastCommonMultiple(firstFraction.Denominator, secondFraction.Denominator);
            var firstMultiplier = leastCommonMultiple / firstFraction.Denominator;
            var secondMultiplier = leastCommonMultiple / secondFraction.Denominator;
            var resultNumerator = (firstFraction.Numerator * firstMultiplier) + (secondMultiplier * secondFraction.Numerator);
            return new Fraction($"{resultNumerator}/{leastCommonMultiple}");
        }

        private static int CalculateLeastCommonMultiple(int a, int b)
        {
            return a / GreatesCommonDivisor(a, b) * b;
        }

        private static int GreatesCommonDivisor(int a, int b)
        {
            return b != 0 ? GreatesCommonDivisor(b, a % b) : a;
        }
    }
}