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
        public void LongestCommonPrefix_WhenInputStringsAreAllDifferentSingleCharacterStrings_ReturnsEmptyString()
        {
            string[] input = { "a", "b", "c" };
            string expected = "";

            var result = _sut.LongestCommonPrefix(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LongestCommonPrefix_WhenInputStringsAreAllSameSingleCharacterString_ReturnsThatCharacterString()
        {
            string[] input = { "a", "a", "a" };
            string expected = "a";

            var result = _sut.LongestCommonPrefix(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LongestCommonPrefix_WhenInputStringsAreAllSameTwoCharacterString_ReturnsThatCharacterString()
        {
            string[] input = { "ab", "ab", "ab" };
            string expected = "ab";

            var result = _sut.LongestCommonPrefix(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LongestCommonPrefix_WhenInputStringsAreAllSameTwoCharacterStringOneWithExtraChar_ReturnsTheTwoCharacterString()
        {
            string[] input = { "ab", "ab", "abc" };
            string expected = "ab";

            var result = _sut.LongestCommonPrefix(input);

            Assert.AreEqual(expected, result);
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
