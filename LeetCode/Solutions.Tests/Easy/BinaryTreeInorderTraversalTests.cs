using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class BinaryTreeInorderTraversalTests
    {
        private readonly BinaryTreeInorderTraversal _binaryTreeInorderTraversal;
        public BinaryTreeInorderTraversalTests()
        {
            _binaryTreeInorderTraversal = new BinaryTreeInorderTraversal();
        }

        [TestMethod]
        public void InorderTraversal_WhenPassedEmptyNode_ReturnsEmptyNode()
        {
            // Arrange
            TreeNode input = null;

            // Act
            var actual = _binaryTreeInorderTraversal.InorderTraversal(input);

            // Assert
            Assert.AreEqual(actual.Count, 0);
        }

        [TestMethod]
        public void InorderTraversal_WhenPassedNonEmptyNode_ReturnsNonEmptyNode()
        {
            // Arrange
            TreeNode input = new TreeNode();

            // Act
            var actual = _binaryTreeInorderTraversal.InorderTraversal(input);

            // Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void InOrderTraversal_WhenPassedExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            TreeNode input = new TreeNode();
            input.val = 1;
            input.left = new TreeNode() { 
                val = 3, 
                left = new TreeNode() { 
                    val = 2 
                }, 
                right = null 
            };

            IList<int> expected = new List<int>() { 1, 3, 2 };

            // Act
            var actual = _binaryTreeInorderTraversal.InorderTraversal(input);

            // Assert
            CollectionAssert.AreEquivalent(expected.ToArray(), actual.ToArray());
        }
    }
}
