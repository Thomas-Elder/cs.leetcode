using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class ValidParenthesesTests
    {

        private readonly ValidParentheses _sut;

        public ValidParenthesesTests()
        {
            _sut = new ValidParentheses();
        }

        [TestMethod]
        public void ValidParentheses_WhenCalledWithStringOnlyOpenParen_ReturnsFalse()
        {
            string input = "{";

            var result = _sut.IsValid(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidParentheses_WhenCalledWithStringOpenParenAndClose_ReturnsTrue()
        {
            string input = "()";

            var result = _sut.IsValid(input);

            Assert.IsTrue(result);
        } 

        [TestMethod]
        public void ValidParentheses_WhenCalledWithStringThreeIndependentOpenAndClosed_ReturnsTrue()
        {
            string input = "()[]{}";

            var result = _sut.IsValid(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidParentheses_WhenCalledWithStringMisMatchedParens_ReturnsFalse()
        {
            string input = "{)";

            var result = _sut.IsValid(input);

            Assert.IsFalse(result);
        }
    }
}

