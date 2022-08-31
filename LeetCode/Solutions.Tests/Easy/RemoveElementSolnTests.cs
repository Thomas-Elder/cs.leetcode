using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class RemoveElementSolnTests
    {
        private readonly RemoveElementSoln _sut;

        public RemoveElementSolnTests()
        {
            _sut = new RemoveElementSoln();
        }

        [TestMethod]
        public void RemoveElementSoln_WhenPassedAnEmptyArray_Returns0()
        {
            // Arrange
            int [] inputArray = {};
            int inputVal = 0;
            int expected = 0;

            // Act 
            var actual = _sut.RemoveElement(inputArray, inputVal);

            // Assert
            Assert.AreEqual(expected, actual);
            }

        [TestMethod]
        public void RemoveElementSoln_WhenPassedAValNotInArray_ReturnsArrayLength()
        {
            // Arrange
            int[] inputArray = {1, 2, 3, 4, 5};
            int inputVal = 0;
            int expected = 5;

            // Act 
            var actual = _sut.RemoveElement(inputArray, inputVal);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveElementSoln_WhenPassedAValOnceInArray_ReturnsArrayLenghtMinus1()
        {
            // Arrange
            int[] inputArray = {1, 2, 3, 4, 5};
            int inputVal = 1;
            int expected = 4;

            // Act 
            var actual = _sut.RemoveElement(inputArray, inputVal);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveElementSoln_WhenPassedAValTwiceInArray_Returns2()
        {
            // Arrange
            int[] inputArray = { 1, 2, 3, 4, 1 };
            int inputVal = 1;
            int expected = 3;

            // Act 
            var actual = _sut.RemoveElement(inputArray, inputVal);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveElementSoln_WhenPassedAValThriceInArray_Returns3()
        {
            // Arrange
            int[] inputArray = { 0,1,2,2,3,0,4,2 };
            int inputVal = 2;
            int expected = 5;

            // Act 
            var actual = _sut.RemoveElement(inputArray, inputVal);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
