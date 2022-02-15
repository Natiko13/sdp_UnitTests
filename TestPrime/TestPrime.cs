using System;
using FluentAssertions;
using NUnit.Framework;
using Quality;

namespace TestPrime
{
    public class TestPrime
    {
        [Test]
        public void NegativeValueException()

        {
            Assert.Throws<ArgumentException>(() => QualityChecker.IsQuality(-5));
        }
         
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]

        public void ValueIsPrime(int value, bool expectedValue)
        {
            //act
            var actualValue = QualityChecker.IsQuality(value);
            //assert
            actualValue.Should().Be(expectedValue);
        }
    }
}
