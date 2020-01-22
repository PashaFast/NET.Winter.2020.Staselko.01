using NUnit.Framework;
using System;

namespace NumbersExtension.Tests.NUnit
{
    public class NumberExtensionTests
    {
        [TestCase(2728, 655, 3, 8, ExpectedResult = 2680)]
        [TestCase(554216104, 15, 0, 31, ExpectedResult = 15)]
        [TestCase(-55465467, 345346, 0, 31, ExpectedResult = 345346)]
        [TestCase(554216104, 4460559, 11, 18, ExpectedResult = 554203816)]
        [TestCase(-1, 0, 31, 31, ExpectedResult = 2147483647)]
        [TestCase(-2147483648, 2147483647, 0, 30, ExpectedResult = -1)]
        [TestCase(-2223, 5440, 18, 23, ExpectedResult = -16517295)]
        [TestCase(2147481425, 5440, 18, 23, ExpectedResult = 2130966353)]
        public int InsertNumbers_SomeNumbers_ExpectedResult(int numberSource, int numberIn, int i, int j)
        {
            return NumbersExtension.InsertNumberIntoAnother(numberSource, numberIn, i, j);
        }
        [Test]
        public void InsertNumberIntoAnother_ArgumentException() =>
            Assert.Throws<ArgumentException>(() => NumbersExtension.InsertNumberIntoAnother(8, 15, 8, 3),
                message: "i must be less then j");

        [Test]
        public void InsertNumberIntoAnother_ArgumentOutOfRangeException_Less() =>
            Assert.Throws<ArgumentOutOfRangeException>(() => NumbersExtension.InsertNumberIntoAnother(8, 15, -1, 3),
                message: "index must be positive");

        [Test]
        public void InsertNumberIntoAnother_ArgumentOutOfRangeException_More() =>
            Assert.Throws<ArgumentOutOfRangeException>(() => NumbersExtension.InsertNumberIntoAnother(8, 15, 32, 32),
                message: "index must be less then 32");

        [Test]
        public void InsertNumberIntoAnother_ArgumentOutOfRangeException_MoreAndLess() =>
            Assert.Throws<ArgumentOutOfRangeException>(() => NumbersExtension.InsertNumberIntoAnother(8, 15, 0, 32),
                message: "index must be less then 32");


        [TestCase(1234321, ExpectedResult = true)]
        [TestCase(1111111, ExpectedResult = true)]
        public bool IsPalindrome_PositiveNumbers_True(int number)
        {
            return NumbersExtension.IsPalindrome(number);
        }

        [TestCase(-1234321, ExpectedResult = true)]
        [TestCase(-1111111, ExpectedResult = true)]
        public bool IsPalindrome_NegativeNumbers_True(int number)
        {
            return NumbersExtension.IsPalindrome(number);
        }

        [TestCase(-123210, ExpectedResult = false)]
        [TestCase(123421, ExpectedResult = false)]
        [TestCase(78, ExpectedResult = false)]
        public bool IsPalindrome_SomeNumbers_False(int number)
        {
            return NumbersExtension.IsPalindrome(number);
        }

    }
}