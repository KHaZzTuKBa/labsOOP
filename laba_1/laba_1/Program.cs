using System;
using System.Text;
using laba_1;

namespace Programm
{
    class Solution
    {
        static void Main(string[] args)
        {
            Rational firstRational = new Rational(5, 10);
            Rational secondRational = new Rational(4, 3);

            Console.WriteLine("Test gcd operation:");
            Console.WriteLine(firstRational);
            Console.WriteLine();

            Console.WriteLine("Output rational numbers:");
            Console.WriteLine(firstRational.ToString());  // Answer: 1/2
            Console.WriteLine(secondRational.ToString()); // Answer: 4/3
            Console.WriteLine();

            Console.WriteLine("Regular math operations:");
            Console.WriteLine(firstRational + secondRational); // Answer: 11/6
            Console.WriteLine(firstRational - secondRational); // Answer: -5/6
            Console.WriteLine(firstRational * secondRational); // Answer: 2/3
            Console.WriteLine(firstRational / secondRational); // Answer: 3/8
            Console.WriteLine();

            Console.WriteLine("Negative rational number:");
            Console.WriteLine(-firstRational); // Answer: -1/2
            Console.WriteLine();

            Console.WriteLine("Fractional comparisons:");
            Console.WriteLine(firstRational == secondRational); // Answer: False
            Console.WriteLine(firstRational != secondRational); // Answer: True
            Console.WriteLine(firstRational < secondRational);  // Answer: True
            Console.WriteLine(firstRational <= secondRational); // Answer: True
            Console.WriteLine(firstRational > secondRational);  // Answer: False
            Console.WriteLine(firstRational >= secondRational); // Answer: False
        }
    }
}