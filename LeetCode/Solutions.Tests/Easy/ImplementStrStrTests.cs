using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class ImplementStrStrTests
    {
        private readonly ImplementStrStr _implementStrStr;

        public ImplementStrStrTests()
        {
            _implementStrStr = new ImplementStrStr();
        }

        [TestMethod]
        public void StrStr_WhenCalledWithEmptyNeedle_ReturnsZero()
        {
            // Arrange
            string inputHaystack = "hello";
            string inputNeedle = "";

            int expected = 0;

            // Act
            var actual = _implementStrStr.StrStr(inputHaystack, inputNeedle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StrStr_WhenCalledWithNeedleNotInHaystack_ReturnsMinusOne()
        {
            // Arrange
            string inputHaystack = "hello";
            string inputNeedle = "a";

            int expected = -1;

            // Act
            var actual = _implementStrStr.StrStr(inputHaystack, inputNeedle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StrStr_WhenCalledWithNeedleAt0_ReturnsZero()
        {
            // Arrange
            string inputHaystack = "hello";
            string inputNeedle = "h";

            int expected = 0;

            // Act
            var actual = _implementStrStr.StrStr(inputHaystack, inputNeedle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StrStr_WhenCalledWithNeedleAt1_Returns1()
        {
            // Arrange
            string inputHaystack = "hello";
            string inputNeedle = "e";

            int expected = 1;

            // Act
            var actual = _implementStrStr.StrStr(inputHaystack, inputNeedle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StrStr_WhenCalledWithNeedleAt2_Returns2()
        {
            // Arrange
            string inputHaystack = "hello";
            string inputNeedle = "ll";

            int expected = 2;

            // Act
            var actual = _implementStrStr.StrStr(inputHaystack, inputNeedle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StrStr_WhenCalledWithNeedleSameAsHaystack_Returns0()
        {
            // Arrange
            string inputHaystack = "hello";
            string inputNeedle = "hello";

            int expected = 0;

            // Act
            var actual = _implementStrStr.StrStr(inputHaystack, inputNeedle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StrStr_WhenCalledWithExampleOne_Returns0()
        {
            // Arrange
            string inputHaystack = "sadbutsad";
            string inputNeedle = "sad";

            int expected = 0;

            // Act
            var actual = _implementStrStr.StrStr(inputHaystack, inputNeedle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StrStr_WhenCalledWithExample63_Returns4()
        {
            // Arrange
            string inputHaystack = "mississippi";
            string inputNeedle = "issip";

            int expected = 4;

            // Act
            var actual = _implementStrStr.StrStr(inputHaystack, inputNeedle);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
