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

        [TestMethod]
        public void PostOrderTraversal_WhenPassedEmptyNode_ReturnsEmptyNode()
        {
            // Arrange
            TreeNode input = null;

            // Act
            var actual = _binaryTree.PostOrderTraversal(input);

            // Assert
            Assert.AreEqual(actual.Count, 0);
        }

        [TestMethod]
        public void PostOrderTraversal_WhenPassedNonEmptyNode_ReturnsNonEmptyNode()
        {
            // Arrange
            TreeNode input = new TreeNode();

            // Act
            var actual = _binaryTree.PostOrderTraversal(input);

            // Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void PostOrderTraversal_WhenPassedExampleOne_ReturnsExpectedResult()
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

            IList<int> expected = new List<int>() { 3, 2, 1 };

            // Act
            var actual = _binaryTree.PostOrderTraversal(input);

            // Assert
            CollectionAssert.AreEquivalent(expected.ToArray(), actual.ToArray());
        }

        [TestMethod]
        public void IsSameTree_WhenPassedIdenticalTrees_ReturnsTrue()
        {
            // Arrange
            TreeNode p = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2
                },
                right = new TreeNode()
                {
                    val = 3
                }
            };

            TreeNode q = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2
                },
                right = new TreeNode()
                {
                    val = 3
                }
            };

            // Act
            var actual = _binaryTree.IsSameTree(p, q);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsSameTree_WhenPassedDifferringTrees_ReturnsFalse()
        {
            // Arrange
            TreeNode p = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 3
                },
                right = new TreeNode()
                {
                    val = 2
                }
            };

            TreeNode q = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2
                },
                right = new TreeNode()
                {
                    val = 3
                }
            };

            // Act
            var actual = _binaryTree.IsSameTree(p, q);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsSameTree_WhenPassedValuesOnDifferentSides_ReturnsFalse()
        {
            // Arrange
            TreeNode p = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 1
                }
            };

            TreeNode q = new TreeNode()
            {
                val = 1,
                left = null,
                right = new TreeNode()
                {
                    val = 1
                }
            };

            // Act
            var actual = _binaryTree.IsSameTree(p, q);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
