using System;
using FractionAddition.ConsoleApp;
using Xunit;

namespace Tests
{
    public class WhenOperationIsParsing
    {
        [Fact]
        public void StringWithOnlySpacesThrowsInvalidOperationException()
        {
            var operatorString = " ";

            Action action = () => Operation.Parse(operatorString);

            var invalidOperationException = Assert.Throws<InvalidOperationException>(action);
            Assert.Equal("Operation it is not white space", invalidOperationException.Message);
        }

        [Fact]
        public void PlusStringParsingToAdditionOperation()
        {
            var plusString = "+";

            var operation = Operation.Parse(plusString);

            Assert.IsType<AdditionOperation>(operation);
        }

        [Fact]
        public void PlusStringWithSpacesParsingToAdditionOperation()
        {
            var plusWithSpacesString = " + ";

            var operation = Operation.Parse(plusWithSpacesString);

            Assert.IsType<AdditionOperation>(operation);
        }

        [Fact]
        public void StringWithAnotherSymbolThrowsInvalidOperationException()
        {
            var stringWithAnotherSymbol = "0";

            Action action = () => Operation.Parse(stringWithAnotherSymbol);

            var invalidOperationException = Assert.Throws<InvalidOperationException>(action);
            Assert.Equal("This operation is not support", invalidOperationException.Message);
        }
    }
}