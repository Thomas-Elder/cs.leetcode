using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public class ZigZagConversionTests
    {
        private readonly ZigZagConversion _zigZagConversion;

        public ZigZagConversionTests()
        {
            _zigZagConversion = new ZigZagConversion();
        }

        [TestMethod]
        public void Convert_WhenGivenAStringLength1_ReturnsTheSameString()
        {
            // Arrange
            var inputString = "A";
            var inputInt = 1;
            var expected = "A";

            // Act
            var actual = _zigZagConversion.Convert(inputString, inputInt);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_WhenGivenExampleOne_ReturnsExpectedAnswer()
        {
            // Arrange
            var inputString = "PAYPALISHIRING";
            var inputInt = 3;
            var expected = "PAHNAPLSIIGYIR";

            // Act
            var actual = _zigZagConversion.Convert(inputString, inputInt);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_WhenGivenExampleTwo_ReturnsExpectedAnswer()
        {
            // Arrange
            var inputString = "PAYPALISHIRING";
            var inputInt = 4;
            var expected = "PINALSIGYAHRPI";

            // Act
            var actual = _zigZagConversion.Convert(inputString, inputInt);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
