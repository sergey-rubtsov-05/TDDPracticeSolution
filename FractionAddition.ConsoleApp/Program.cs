using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionAddition.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFraction = new Fraction(Console.ReadLine());
            var operation = Operation.Parse(Console.ReadLine());
            var secondFraction = new Fraction(Console.ReadLine());
            Console.WriteLine(firstFraction + secondFraction);
            Console.ReadKey();
        }
    }
}
