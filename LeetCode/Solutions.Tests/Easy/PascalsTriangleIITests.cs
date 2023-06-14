using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;
using System.Collections.Generic;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class PascalsTriangleIITests
    {
        private readonly PascalsTriangleII _pascalsTriangleII;

        public PascalsTriangleIITests()
        {
            _pascalsTriangleII = new PascalsTriangleII();
        }


        [TestMethod]
        public void GetRow_WhenPassedExampleOne_ReturnsExpectedOutput()
        {
            // Arrange
            var input = 3;
            var expected = new List<int>() { 1, 3, 3, 1 };

            // Act
            var actual = _pascalsTriangleII.GetRow(input);

            // Assert
            CollectionAssert.AreEqual(expected, (System.Collections.ICollection)actual);
        }

        [TestMethod]
        public void GetRow_WhenPassedExampleTwo_ReturnsExpectedOutput()
        {
            // Arrange
            var input = 0;
            var expected = new List<int>() { 1 };

            // Act
            var actual = _pascalsTriangleII.GetRow(input);

            // Assert
            CollectionAssert.AreEqual(expected, (System.Collections.ICollection)actual);
        }

        [TestMethod]
        public void GetRow_WhenPassedExampleThree_ReturnsExpectedOutput()
        {
            // Arrange
            var input = 1;
            var expected = new List<int>() { 1, 1 };

            // Act
            var actual = _pascalsTriangleII.GetRow(input);

            // Assert
            CollectionAssert.AreEqual(expected, (System.Collections.ICollection)actual);
        }
    }
}
