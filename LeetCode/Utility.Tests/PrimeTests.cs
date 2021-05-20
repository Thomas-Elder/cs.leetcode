using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility;

namespace Utility.Tests
{
    [TestClass]
    public class PrimeTests
    {

        [TestMethod]
        public void PrimeInt_WhenPassed15_ReturnsFalse()
        {
            // Arrange
            Prime prime = new Prime();
            int testValue = 15;
            bool expected = false;

            // Act
            bool actual = prime.IsPrime(testValue);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeInt_WhenPassed17_ReturnsTrue()
        {
            // Arrange
            Prime prime = new Prime();
            int testValue = 17;
            bool expected = true;

            // Act
            bool actual = prime.IsPrime(testValue);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeLong_WhenPassed15_ReturnsFalse()
        {
            // Arrange
            Prime prime = new Prime();
            long testValue = 15;
            bool expected = false;

            // Act
            bool actual = prime.IsPrime(testValue);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeLong_WhenPassed17_ReturnsTrue()
        {
            // Arrange
            Prime prime = new Prime();
            long testValue = 17;
            bool expected = true;

            // Act
            bool actual = prime.IsPrime(testValue);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
