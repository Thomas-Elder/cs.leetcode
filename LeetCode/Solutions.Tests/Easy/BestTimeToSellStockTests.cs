using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;
using System.Collections.Generic;
using System.Threading;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class BestTimeToSellStockTests
    {
        private readonly BestTimeToSellStock _bestTimeToSellStock;

        public BestTimeToSellStockTests()
        {
            _bestTimeToSellStock = new ();
        }

        [TestMethod]
        public void MaxProfit_WhenCalledWithExampleOneInput_ReturnsExpectedResult()
        {
            // Arrange
            var input = new int[] { 7, 1, 5, 3, 6, 4 };
            var expected = 5;

            // Act
            var actual = _bestTimeToSellStock.MaxProfit(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaxProfit_WhenCalledWithExampleTwoInput_ReturnsExpectedResult()
        {
            // Arrange
            var input = new int[] { 7, 6, 4, 3, 1 };
            var expected = 0;

            // Act
            var actual = _bestTimeToSellStock.MaxProfit(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
