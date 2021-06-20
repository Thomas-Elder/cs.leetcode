using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class SumOfAllSubsetXORTotalsTests
    {

        [TestMethod]
        public void SubsetXORSum_WhenGivenLCExample1_ReturnsCorrectValue()
        {
            // Arrange
            SumOfAllSubsetXORTotals sumOfAllSubsetXORTotals = new SumOfAllSubsetXORTotals();
            int[] nums = { 1, 3 };
            int expected = 6;

            // Act
            int actual = sumOfAllSubsetXORTotals.SubsetXORSum(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubsetXORSum_WhenGivenLCExample2_ReturnsCorrectValue()
        {
            // Arrange
            SumOfAllSubsetXORTotals sumOfAllSubsetXORTotals = new SumOfAllSubsetXORTotals();
            int[] nums = { 5, 1, 6 };
            int expected = 28;

            // Act
            int actual = sumOfAllSubsetXORTotals.SubsetXORSum(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubsetXORSum_WhenGivenLCExample3_ReturnsCorrectValue()
        {
            // Arrange
            SumOfAllSubsetXORTotals sumOfAllSubsetXORTotals = new SumOfAllSubsetXORTotals();
            int[] nums = { 3, 4, 5, 6, 7, 8 };
            int expected = 480;

            // Act
            int actual = sumOfAllSubsetXORTotals.SubsetXORSum(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
