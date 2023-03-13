using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.Linq;

using Solutions.Easy;

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
        [TestCategory("Traversal")]
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
        [TestCategory("Traversal")]
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
        [TestCategory("Traversal")]
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
        [TestCategory("Traversal")]
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
        [TestCategory("Traversal")]
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
        [TestCategory("Traversal")]
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
        [TestCategory("Traversal")]
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
        [TestCategory("Traversal")]
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
        [TestCategory("Traversal")]
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
        [TestCategory("Shape")]
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
        [TestCategory("Shape")]
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
        [TestCategory("Shape")]
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

        [TestMethod]
        [TestCategory("Shape")]
        public void IsSymmetric_WhenPassedNullNode_ReturnsTrue()
        {
            // Arrange
            var input = new TreeNode();

            // Act
            var result = _binaryTree.IsSymmetric(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void IsSymmetric_WhenPassedSingleNodeWithValue_ReturnsTrue()
        {
            // Arrange
            var input = new TreeNode() { val = 1 };

            // Act
            var result = _binaryTree.IsSymmetric(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void IsSymmetric_WhenPassedSymmetricTree_ReturnsTrue()
        {
            // Arrange
            var input = new TreeNode() {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode()
                    {
                        val = 3
                    },
                    right = new TreeNode()
                    {
                        val = 4
                    }
                },
                right = new TreeNode()
                {
                    val = 2,
                    left= new TreeNode()
                    {
                        val = 4
                    },
                    right= new TreeNode()
                    {
                        val = 3
                    }
                }
            };

            // Act
            var result = _binaryTree.IsSymmetric(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void IsSymmetric_WhenPassedAsymmetricTree_ReturnsFalse()
        {
            // Arrange
            var input = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    right = new TreeNode()
                    {
                        val = 3
                    }
                },
                right = new TreeNode()
                {
                    val = 2,
                    right = new TreeNode()
                    {
                        val = 3
                    }
                }
            };

            // Act
            var result = _binaryTree.IsSymmetric(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void MaxDepth_WhenPassedNullNode_ReturnsOne()
        {
            // Arrange
            var input = new TreeNode();
            var expected = 1;

            // Act
            var result = _binaryTree.MaxDepth(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void MaxDepth_WhenPassedExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            var input = new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 9,
                },
                right = new TreeNode()
                {
                    val = 20,
                    left = new TreeNode()
                    {
                        val = 15
                    },
                    right = new TreeNode()
                    {
                        val = 7
                    }
                }
            };

            var expected = 3;

            // Act
            var result = _binaryTree.MaxDepth(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("Shape")]
        public void MaxDepth_WhenPassedExampleTwo_ReturnsExpectedResult()
        {
            // Arrange
            var input = new TreeNode()
            {
                val = 1,
                right = new TreeNode()
                {
                    val = 2
                }
            };

            var expected = 2;

            // Act
            var result = _binaryTree.MaxDepth(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SortedArrayToBST_WhenPassedExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            var input = new int [] { -10, -3, 0, 5, 9 };

            var expected = new TreeNode()
            {
                val = 0,
                left = new TreeNode()
                {
                    val = -10,
                    left = new TreeNode()
                    {
                        val = -3
                    }
                },
                right = new TreeNode()
                {
                    val = 5,
                    left = new TreeNode()
                    {
                        val = 9
                    }
                }
            };

            // Act
            var actual = _binaryTree.SortedArrayToBST(input);

            // Assert
            Assert.AreEqual(expected.val, actual.val);
            Assert.AreEqual(expected.left.val, actual.left.val);
        }

        [TestMethod]
        public void IsBalanced_WhenPassedExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            var input = new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 9
                },
                right = new TreeNode()
                {
                    val = 20,
                    left = new TreeNode()
                    {
                        val = 15
                    },
                    right = new TreeNode()
                    {
                        val = 7
                    }
                }
            };

            // Act
            var actual = _binaryTree.IsBalanced(input);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsBalanced_WhenPassedExampleTwo_ReturnsExpectedResult()
        {
            // Arrange
            var input = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode()
                    {
                        val = 3,
                        left = new TreeNode()
                        {
                            val = 4
                        },
                        right = new TreeNode()
                        {
                            val = 4
                        }
                    },
                    right = new TreeNode()
                    {
                        val = 3
                    }
                },
                right = new TreeNode()
                {
                    val = 2
                }
            };

            // Act
            var actual = _binaryTree.IsBalanced(input);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsBalanced_WhenPassedExampleFour_ReturnsExpectedResult()
        {
            // Arrange
            var input = new TreeNode()
            {
                val = 1,
                right = new TreeNode()
                {
                    val = 2,
                    right = new TreeNode()
                    {
                        val = 3
                    }
                }
            };

            // Act
            var actual = _binaryTree.IsBalanced(input);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
