using System;

namespace FractionAddition.ConsoleApp
{
    public abstract class Operation
    {
        public static Operation Parse(string operatorString)
        {
            if (string.IsNullOrWhiteSpace(operatorString))
                throw new InvalidOperationException("Operation it is not white space");

            if (operatorString.Contains("+"))
                return new AdditionOperation();

            throw new InvalidOperationException("This operation is not support");
        }
    }
}