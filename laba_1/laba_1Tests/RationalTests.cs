using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1.Tests
{
    [TestClass()]
    public class RationalTests
    {
        [TestMethod()]
        public void testSum()
        {
            Rational firstRational = new Rational(3, 2);
            Rational secondRational = new Rational(8, 15);

            Rational sum = firstRational + secondRational;
            Rational answer = new Rational(61, 30);

            Assert.IsTrue(answer == sum);
        }
        [TestMethod()]
        public void testDec()
        {
            Rational firstRational = new Rational(3, 2);
            Rational secondRational = new Rational(8, 15);

            Rational dec = firstRational - secondRational;
            Rational answer = new Rational(29, 30);
            Assert.IsTrue(dec == answer);
        }

        [TestMethod()]
        public void testNegative()
        {
            Rational rational = new Rational(3, 2);
            rational = -rational;

            Rational negativeRational = new Rational(-3, 2);
            Assert.IsTrue(rational == negativeRational);
        }

        [TestMethod()]
        public void testCompare()
        {
            Rational firstRational = new Rational(3, 2);
            Rational secondRational = new Rational(8, 15);
            Assert.IsTrue(firstRational > secondRational);
        }
    }
}