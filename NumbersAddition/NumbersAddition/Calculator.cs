using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NumbersAddition
{
    public class Calculator : ICalculator
    {
        public int Calculate(string expression)
        {
            var indexOperation = IndexOfPlusOrMinus(expression);
            int leftResult;
            int rightResult;
            if (indexOperation == -1)
            {
                indexOperation = expression.IndexOfAny(new[] { '*', '/' });
                if (indexOperation == -1)
                    return int.Parse(expression);

                leftResult = Calculate(expression.Substring(0, indexOperation));
                rightResult = Calculate(expression.Substring(indexOperation + 1));
                return expression[indexOperation] == '/'
                    ? leftResult / rightResult
                    : leftResult * rightResult;
            }

            leftResult = Calculate(expression.Substring(0, indexOperation));
            rightResult = Calculate(expression.Substring(indexOperation));

            return leftResult + rightResult;
        }

        private int IndexOfPlusOrMinus(string expression)
        {
            for (var i = 1; i < expression.Length; i++)
            {
                var charOfExpression = expression[i];
                if (charOfExpression == '+' || charOfExpression == '-')
                {
                    if (expression[i-1] == '*' || expression[i-1] == '/')
                        continue;

                    return i;
                }
            }
            return -1;
        }
    }
}