using Xunit;

namespace NumbersAddition.Tests
{
    public class WhenCalculating
    {
        [Fact]
        public void SimpleOneNumber()
        {
            var expression = "1";
            ICalculator calculator = CreateCalculator();

            int calculateResult = calculator.Calculate(expression);

            Assert.Equal(1, calculateResult);
        }

        [Fact]
        public void SimpleThreeSighNumber()
        {
            var expression = "111";
            ICalculator calculator = CreateCalculator();

            int calculatedResult = calculator.Calculate(expression);

            Assert.Equal(111, calculatedResult);
        }

        [Fact]
        public void SimpleNegativeNumber()
        {
            var expression = "-3";
            ICalculator calculator = CreateCalculator();

            int calculatedResult = calculator.Calculate(expression);

            Assert.Equal(-3, calculatedResult);
        }

        [Fact]
        public void AdditionTwoNumbers()
        {
            var expression = "1+1";
            ICalculator calculator = CreateCalculator();

            int calculatedResult = calculator.Calculate(expression);

            Assert.Equal(2, calculatedResult);
        }

        [Fact]
        public void SubtractionTwoNumbers()
        {
            var expression = "4-1";
            ICalculator calculator = CreateCalculator();

            int calculatedResult = calculator.Calculate(expression);

            Assert.Equal(3, calculatedResult);
        }

        [Fact]
        public void AdditionThreeNumbers()
        {
            var expression = "1+2+3";
            ICalculator calculator = CreateCalculator();

            int calculatedResult = calculator.Calculate(expression);

            Assert.Equal(6, calculatedResult);
        }

        [Fact]
        public void MixedThreeNumbers()
        {
            var expression = "3+5-1";
            ICalculator calculator = CreateCalculator();

            int calculatedResult = calculator.Calculate(expression);

            Assert.Equal(7, calculatedResult);
        }

        [Fact]
        public void MulplicationTwoNumbers()
        {
            var expression = "3*4";
            ICalculator calculator = CreateCalculator();

            int calculatedResult = calculator.Calculate(expression);

            Assert.Equal(12, calculatedResult);
        }

        [Fact]
        public void DividingTwoNumbers()
        {
            var expression = "8/2";
            ICalculator calculator = CreateCalculator();

            int calculatedResult = calculator.Calculate(expression);

            Assert.Equal(4, calculatedResult);
        }

        [Fact]
        public void ComplexCalculatingNumbers()
        {
            var expression = "8/2+5*3/1";
            ICalculator calculator = CreateCalculator();

            int calculatedResult = calculator.Calculate(expression);

            Assert.Equal(19, calculatedResult);
        }

        [Fact]
        public void DivideNumbersWithNegativeNumbers()
        {
            var expression = "-8/-2";
            ICalculator calculator = CreateCalculator();

            int calculatedResult = calculator.Calculate(expression);

            Assert.Equal(4, calculatedResult);
        }

        private ICalculator CreateCalculator()
        {
            return new Calculator();
        }
    }
}