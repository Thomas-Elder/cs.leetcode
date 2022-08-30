using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility;
using Solutions.Easy;


namespace Solutions.Tests.Easy
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        private readonly RemoveDuplicatesFromSortedArray _sut;

        public RemoveDuplicatesFromSortedArrayTests()
        {
            _sut = new RemoveDuplicatesFromSortedArray();
        }

        [TestMethod]
        public void RemoveDuplicates_ExampleOne_Correct()
        {
            int[] input = { 1, 1, 2 };
            int expected = 2;

            var result = _sut.RemoveDuplicates(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveDuplicates_ExampleTwo_Correct()
        {
            int[] input = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int expected = 5;

            var result = _sut.RemoveDuplicates(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveDuplicates_WhenInputIsEmpty_ReturnsZero()
        {
            int[] input = { };
            int expected = 0;

            var result = _sut.RemoveDuplicates(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveDuplicates_WhenInputHoldsUniqueValues_ReturnsLengthOfInput()
        {
            int[] input = { 1, 2, 3, 4 };
            int expected = 4;

            var result = _sut.RemoveDuplicates(input);

            Assert.AreEqual(expected, result);
        }
    }
}
