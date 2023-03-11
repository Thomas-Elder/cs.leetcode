using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Easy
{
    public class BinaryTree
    {
        private List<int> result;

        #region InOrder
        /// <summary>
        /// Returns a list of values from a binary tree, in order.
        /// </summary>
        /// In the case of binary search trees (BST), Inorder traversal gives nodes in non-decreasing order. 
        /// To get nodes of BST in non-increasing order, a variation of Inorder traversal where Inorder traversal is reversed can be used. 
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            result = new List<int>();

            InOrderRecursive(root);

            return result;
        }

        public void InOrderRecursive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrderRecursive(root.left);

            result.Add(root.val);

            InOrderRecursive(root.right);
        }
        #endregion

        #region PreOrder
        /// <summary>
        /// Returns a list of values from a binary tree, in pre order.
        /// </summary>
        /// Preorder traversal is used to create a copy of the tree.
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreOrderTraversal(TreeNode root)
        {
            result = new List<int>();

            PreOrderRecursive(root);

            return result;
        }

        public void PreOrderRecursive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            result.Add(root.val);
            
            PreOrderRecursive(root.left);
            
            PreOrderRecursive(root.right);
        }
        #endregion

        #region PostOrder
        /// <summary>
        /// Returns a list of values from a binary tree, in post order.
        /// </summary>
        /// Postorder traversal is used to delete the tree.
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostOrderTraversal(TreeNode root)
        {
            result = new List<int>();

            PostOrderRecursive(root);

            return result;
        }

        public void PostOrderRecursive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            PostOrderRecursive(root.left);

            PostOrderRecursive(root.right);

            result.Add(root.val);
        }
        #endregion

        #region IsSameTree
        /// <summary>
        /// Tests to see if two trees are identical in structure and node values
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return IsSameTreeRecursive(p, q);
        }

        /// <summary>
        /// Traverses two trees in parallel, recursively and returns false if values differ at any point.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool IsSameTreeRecursive(TreeNode p, TreeNode q)
        {
            // First, if both are null, then this node is equal
            if (p == null && q == null)
            {
                return true;
            }

            // Secondly, if they're not null, we need to compare their values, then recurse down both branches
            if (p != null && q != null)
            {
                return (p.val == q.val
                        && IsSameTreeRecursive(p.left, q.left)
                        && IsSameTreeRecursive(p.right, q.right));
            }

            // We get here if only one node was null, and return false
            return false;
        }
        #endregion

        #region IsSymmetric
        /// <summary>
        /// Traverses a tree and returns true if is is symmetrical around the root
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric(TreeNode root)
        {
            return IsSymmetricRecursive(root.left, root.right);
        }

        /// <summary>
        /// Recursively traverses two branches in parallel, returns true if the left.left == right.right
        /// for all nodes in the tree.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public bool IsSymmetricRecursive(TreeNode left, TreeNode right)
        {
            // If both are null, that's symmetric
            if (left == null && right == null)
            {
                return true;
            }

            // Here if either is null, we know the other isn't (from the previous check)
            // so it's not symmetric
            if (left == null || right == null)
            {
                return false;
            }

            // Now check the values, and pass the leftleft with the rightright, and
            // the leftright with the rightleft!
            return (left.val == right.val
                && IsSymmetricRecursive(left.left, right.right) 
                && IsSymmetricRecursive(left.right, right.left));
        }
        #endregion

        #region MaxDepth
        /// <summary>
        /// Gets the maximum depth of a given binary tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            } else
            {
                int countLeft = MaxDepth(root.left);
                int countRight = MaxDepth(root.right);

                if (countLeft > countRight)
                {
                    return countLeft + 1;
                } else
                {
                    return countRight + 1;
                }
            }
        }
        #endregion
    }
}
