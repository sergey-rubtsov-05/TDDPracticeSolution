using System.Linq;

namespace NumbersAddition
{
    public class Calculator : ICalculator
    {
        public int Calculate(string expression)
        {
            var indexOfOperation = IndexOfOperation(expression);
            if (indexOfOperation == -1)
                return int.Parse(expression);

            var operation = expression[indexOfOperation];

            var leftResult = Calculate(expression.Substring(0, indexOfOperation));
            var rightResult =
                Calculate(expression.Substring("*/".Contains(operation) ? indexOfOperation + 1 : indexOfOperation));

            switch (operation)
            {
                case '*':
                    return leftResult * rightResult;
                case '/':
                    return leftResult / rightResult;
                default:
                    return leftResult + rightResult;
            }
        }

        private int IndexOfOperation(string expression)
        {
            for (var i = 1; i < expression.Length; i++)
            {
                var charOfExpression = expression[i];
                if (charOfExpression == '+' || charOfExpression == '-')
                {
                    if (expression[i - 1] == '*' || expression[i - 1] == '/')
                        continue;

                    return i;
                }
            }
            return expression.IndexOfAny(new[] { '*', '/' });
        }
    }
}