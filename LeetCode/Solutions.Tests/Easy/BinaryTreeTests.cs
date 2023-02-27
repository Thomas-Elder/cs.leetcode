using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class BinaryTreeTests
    {
        private readonly BinaryTree _binaryTree;
        public BinaryTreeTests()
        {
            _binaryTree = new BinaryTree();
        }

        [TestMethod]
        public void InorderTraversal_WhenPassedEmptyNode_ReturnsEmptyNode()
        {
            // Arrange
            TreeNode input = null;

            // Act
            var actual = _binaryTree.InorderTraversal(input);

            // Assert
            Assert.AreEqual(actual.Count, 0);
        }

        [TestMethod]
        public void InorderTraversal_WhenPassedNonEmptyNode_ReturnsNonEmptyNode()
        {
            // Arrange
            TreeNode input = new TreeNode();

            // Act
            var actual = _binaryTree.InorderTraversal(input);

            // Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void InOrderTraversal_WhenPassedExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            TreeNode input = new TreeNode();
            input.val = 1;
            input.left = new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 2
                },
                right = null
            };

            IList<int> expected = new List<int>() { 1, 3, 2 };

            // Act
            var actual = _binaryTree.InorderTraversal(input);

            // Assert
            CollectionAssert.AreEquivalent(expected.ToArray(), actual.ToArray());
        }

        [TestMethod]
        public void PreOrderTraversal_WhenPassedEmptyNode_ReturnsEmptyNode()
        {
            // Arrange
            TreeNode input = null;

            // Act
            var actual = _binaryTree.PreOrderTraversal(input);

            // Assert
            Assert.AreEqual(actual.Count, 0);
        }

        [TestMethod]
        public void PreOrderTraversal_WhenPassedNonEmptyNode_ReturnsNonEmptyNode()
        {
            // Arrange
            TreeNode input = new TreeNode();

            // Act
            var actual = _binaryTree.PreOrderTraversal(input);

            // Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void PreOrderTraversal_WhenPassedExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            TreeNode input = new TreeNode();
            input.val = 1;
            input.left = new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 2
                },
                right = null
            };

            IList<int> expected = new List<int>() { 1, 2, 3 };

            // Act
            var actual = _binaryTree.PreOrderTraversal(input);

            // Assert
            CollectionAssert.AreEquivalent(expected.ToArray(), actual.ToArray());
        }
    }
}
