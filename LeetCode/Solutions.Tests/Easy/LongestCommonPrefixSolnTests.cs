using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class LongestCommonPrefixSolnTests
    {

        private readonly LongestCommonPrefixSoln _sut;

        public LongestCommonPrefixSolnTests()
        {
            _sut = new LongestCommonPrefixSoln();
        }

        [TestMethod]
        public void LongestCommonPrefix_WhenCalledWithExample1_ReturnsCorrectOutput()
        {
            string[] input = { "flower", "flow", "flight" };
            string expected = "fl";

            var result = _sut.LongestCommonPrefix(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LongestCommonPrefix_WhenCalledWithExample2_ReturnsCorrectOutput()
        {
            string[] input = { "dog", "racecar", "car" };
            string expected = "";

            var result = _sut.LongestCommonPrefix(input);

            Assert.AreEqual(expected, result);
        }
    }
}
