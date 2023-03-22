using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;
using System.Collections.Generic;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class PascalsTriangleTests
    {
        private readonly PascalsTriangle _pascalsTriangle;

        public PascalsTriangleTests()
        {
            _pascalsTriangle = new PascalsTriangle();
        }

        [TestMethod]
        public void Generate_WhenCalledWithExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            var input = 5;

            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() { 1 });
            expected.Add(new List<int>() { 1, 1 });
            expected.Add(new List<int>() { 1, 2, 1 });
            expected.Add(new List<int>() { 1, 3, 3, 1 });
            expected.Add(new List<int>() { 1, 4, 6, 4, 1});

            // Act
            var actual = _pascalsTriangle.Generate(input);

            // Assert
            Assert.AreEqual(expected[2][1], actual[2][1]);
            Assert.AreEqual(expected[3][2], actual[3][2]);
        }
    }
}
