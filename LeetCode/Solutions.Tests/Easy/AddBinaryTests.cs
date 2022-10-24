using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class AddBinaryTests
    {
        private readonly AddBinary _addBinary;

        public AddBinaryTests()
        {
            _addBinary = new AddBinary();
        }

        [TestMethod]
        public void AddBinaryStrings_WhenGivenTwoZeroStrings_ReturnsZeroString()
        {
            // Arrange
            string inputA = "0";
            string inputB = "0";
            string expected = "0";

            // Act
            string actual = _addBinary.AddBinaryStrings(inputA, inputB);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddBinaryStrings_WhenGivenTwoStringsDifferentLengths_Returns4String()
        {
            // Arrange
            string inputA = "11";
            string inputB = "1";
            string expected = "100";

            // Act
            string actual = _addBinary.AddBinaryStrings(inputA, inputB);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddBinaryStrings_WhenGivenOneAndZeroStrings_ReturnsOneString()
        {
            // Arrange
            string inputA = "0";
            string inputB = "1";
            string expected = "1";

            // Act
            string actual = _addBinary.AddBinaryStrings(inputA, inputB);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddBinaryStrings_WhenGivenTwoOneStrings_ReturnsTwoString()
        {
            // Arrange
            string inputA = "1";
            string inputB = "1";
            string expected = "10";

            // Act
            string actual = _addBinary.AddBinaryStrings(inputA, inputB);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddBinaryStrings_WhenGivenConsecutiveCarriesStrings_ReturnsStringCorrectlyCalculated()
        {
            // Arrange
            string inputA = "11";
            string inputB = "11";
            string expected = "110";

            // Act
            string actual = _addBinary.AddBinaryStrings(inputA, inputB);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
