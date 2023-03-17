using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;
namespace Solutions.Tests.Medium
{
    [TestClass]
    public class PrefixTreeTests
    {
        private readonly PrefixTree _prefixTree;
        public PrefixTreeTests()
        {
            _prefixTree = new PrefixTree();
        }

        [TestMethod]
        public void Insert_WhenCalledWithString_InsertsStringIntoTrie()
        {
            // Arrange
            string input = "input";

            // Act 
            _prefixTree.Insert(input);
            var actual = _prefixTree.Search(input);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Search_WhenCalledWithNonExistentString_ReturnsFalse()
        {
            // Arrange
            string input = "existingWord";
            string nonExistingWord = "nonExistingWord";

            // Act 
            _prefixTree.Insert(input);
            var actual = _prefixTree.Search(nonExistingWord);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Search_WhenCalledWithExistingString_ReturnsTrue()
        {
            // Arrange
            string input = "existingWord";
            string existingWord = "existingWord";

            // Act 
            _prefixTree.Insert(input);
            var actual = _prefixTree.Search(existingWord);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void StartsWith_WhenCalledWithNonExistentPrefix_ReturnsFalse()
        {
            // Arrange
            string input = "existingWord";
            string nonExistingPrefix = "nonExistingPrefix";

            // Act 
            _prefixTree.Insert(input);
            var actual = _prefixTree.StartsWith(nonExistingPrefix);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void StartsWith_WhenCalledWithExistingPrefix_ReturnsTrue()
        {
            // Arrange
            string input = "existingWord";
            string existingPrefix = "existing";

            // Act 
            _prefixTree.Insert(input);
            var actual = _prefixTree.StartsWith(existingPrefix);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}
