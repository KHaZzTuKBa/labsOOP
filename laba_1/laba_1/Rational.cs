using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public class Rational
    {
        private readonly int _numerator;
        private readonly int _denominator;



        public Rational(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException("Denominator cannot be zero.");

            int gcd = GCD(numerator, denominator);
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;

            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        public static Rational operator +(Rational firstNumber, Rational secondNumber)
        {
            int newNumerator = firstNumber._numerator * secondNumber._denominator + secondNumber._numerator * firstNumber._denominator;
            int newDenominator = firstNumber._denominator * secondNumber._denominator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator -(Rational firstNumber, Rational secondNumber)
        {
            int newNumerator = firstNumber._numerator * secondNumber._denominator - secondNumber._numerator * firstNumber._denominator;
            int newDenominator = firstNumber._denominator * secondNumber._denominator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator *(Rational firstNumber, Rational secondNumber)
        {
            int newNumerator = firstNumber._numerator * secondNumber._numerator;
            int newDenominator = firstNumber._denominator * secondNumber._denominator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator /(Rational firstNumber, Rational secondNumber)
        {
            int newNumerator = firstNumber._numerator * secondNumber._denominator;
            int newDenominator = firstNumber._denominator * secondNumber._numerator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator -(Rational firstNumber)
        {
            return new Rational(-firstNumber._numerator, firstNumber._denominator);
        }

        public static bool operator ==(Rational firstNumber, Rational secondNumber)
        {
            return firstNumber._numerator == secondNumber._numerator && firstNumber._denominator == secondNumber._denominator;
        }

        public static bool operator !=(Rational firstNumber, Rational secondNumber)
        {
            return !(firstNumber == secondNumber);
        }

        public static bool operator <(Rational firstNumber, Rational secondNumber)
        {
            return firstNumber._numerator * secondNumber._denominator < secondNumber._numerator * firstNumber._denominator;
        }

        public static bool operator <=(Rational firstNumber, Rational secondNumber)
        {
            return firstNumber._numerator * secondNumber._denominator <= secondNumber._numerator * firstNumber._denominator;
        }

        public static bool operator >(Rational firstNumber, Rational secondNumber)
        {
            return firstNumber._numerator * secondNumber._denominator > secondNumber._numerator * firstNumber._denominator;
        }

        public static bool operator >=(Rational firstNumber, Rational secondNumber)
        {
            return firstNumber._numerator * secondNumber._denominator >= secondNumber._numerator * firstNumber._denominator;
        }

        private static int GCD(int numerator, int denominator)
        {
            return denominator == 0 ? numerator : GCD(denominator, numerator % denominator);
        }
    }
}
