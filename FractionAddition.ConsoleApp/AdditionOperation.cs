namespace FractionAddition.ConsoleApp
{
    public class AdditionOperation : Operation
    {
        public Fraction Execute(Fraction firstFraction, Fraction secondFraction)
        {
            return firstFraction + secondFraction;
        }
    }
}