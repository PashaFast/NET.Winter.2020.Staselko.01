using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NumbersExtension.Tests.MSUnit
{
    [TestClass]
    public class NumbersExtensionTests
    {
        [TestMethod]
        public void InsertNumberTest()
        {
            int expected = 345346;

            int result = NumbersExtension.InsertNumberIntoAnother(-55465467, 345346, 0, 31);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InsertNumberIntoAnotherWith14_50_Return_22()
        {
            int sourceNumber = 14;
            int numberln = 50;
            int i = 3;
            int j = 6;
            int expected = 22;
            int actual = NumbersExtension.InsertNumberIntoAnother(sourceNumber, numberln, i, j);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertNumberIntoAnotherWithBigNumbers()
        {
            int sourceNumber = 554216104;
            int numberln = 4460559;
            int i = 11;
            int j = 18;
            int expected = 554203816;
            int actual = NumbersExtension.InsertNumberIntoAnother(sourceNumber, numberln, i, j);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SInsertNumberIntoAnother_Throw_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => NumbersExtension.InsertNumberIntoAnother(10, 45, 23, 12),
                message: "Method generates ArgumentException in case i more then j");
        }

        [TestMethod]
        public void IsPalindrome_PositiveNumber_True()
        {
            bool expected = true;

            bool result = NumbersExtension.IsPalindrome(1234321);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPalindrome_PositiveNumber_False()
        {
            bool expected = false;

            bool result = NumbersExtension.IsPalindrome(12345321);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void IsPalindrome_Throw_ArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => NumbersExtension.IsPalindrome(-111),
                message: " number cannot be negative");
        }

    }
}
