using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

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
            Assert.IsNull(actual);
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
    }
}
