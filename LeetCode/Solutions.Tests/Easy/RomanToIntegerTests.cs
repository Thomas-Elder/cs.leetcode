using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class RomanToIntegerTests
    {
        private RomanToInteger _romanToInteger;

        [TestMethod]
        public void RomanToInt_WhenCalledWithLCExample_ReturnsCorrectResult()
        {
            // Arrange
            var expected = 3;
            var input = "III";

            _romanToInteger = new RomanToInteger();

            // Act
            var result = _romanToInteger.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RomanToInt_WhenCalledWithSecondLCExample_ReturnsCorrectResult()
        {
            // Arrange
            var expected = 58;
            var input = "LVIII";

            _romanToInteger = new RomanToInteger();

            // Act
            var result = _romanToInteger.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RomanToInt_WhenCalledWithThirdLCExample_ReturnsCorrectResult()
        {
            // Arrange
            var expected = 1994;
            var input = "MCMXCIV";

            _romanToInteger = new RomanToInteger();

            // Act
            var result = _romanToInteger.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
