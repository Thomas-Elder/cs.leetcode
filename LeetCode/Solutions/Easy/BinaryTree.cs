﻿using System;
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

        #region SortedArrayToBST
        /// <summary>
        /// Converts a sorted array of integers to a height-balanced binary tree
        /// </summary>
        /// A height balanced binary tree is one where the depth of the two sub trees of any node
        /// never differs by more than one.
        /// <param name="nums"></param>
        /// <returns></returns>
        public TreeNode SortedArrayToBST(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;

            return SortedArrayToBSTRecursive(nums, start, end);
        }

        public TreeNode SortedArrayToBSTRecursive(int[] nums, int start, int end)
        {
            // Terminating case
            if (start > end) { return null; }

            int mid = (start + end) / 2;

            // The mid point is going to be a new root
            TreeNode root = new TreeNode() { val = nums[mid]};

            // Recure on the left node 
            root.left = SortedArrayToBSTRecursive(nums, start, mid - 1);

            // And right node
            root.right = SortedArrayToBSTRecursive(nums, mid + 1, end);

            return root;
        }
        #endregion

        #region IsBalanced
        /// <summary>
        /// Given a binary tree, returns whether it is height-balanced
        /// </summary>
        /// A height balanced binary tree is one where the depth of the two sub trees of any node
        /// never differs by more than one.
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsBalanced(TreeNode root)
        {
            int height = Height(root);
            if (height < 0) { return false; }

            return true;
        }

        /// <summary>
        /// Returns the height of a height-balanced binary tree.
        /// </summary>
        /// If the tree is not height balanced, returns -1.
        /// <param name="root"></param>
        /// <returns></returns>
        public int Height(TreeNode root)
        {
            if (root == null) { return 0; }

            // Recurr down the left branch
            int leftHeight = Height(root.left);
            // If at any point we've already returned -1, the tree is not balanced
            if (leftHeight == -1) { return -1; }

            int rightHeight = Height(root.right);
            if (rightHeight == -1) { return -1; }

            if (Math.Abs(leftHeight - rightHeight) > 1) { return -1; }

            return leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;
        }
        #endregion

        #region MinDepth
        /// <summary>
        /// Returns the number of nodes along the shortest path from the root node down to the nearest leaf node.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MinDepth(TreeNode root)
        {
            if (root == null) { return 0; }

            // Base case for recursion
            // If left and right nodes are null, we're on a leaf node.
            // We return 1, to add 1 to the depth count for this node.
            if (root.left == null && root.right == null) { return 1; }

            // If the left node is null, then we need to keep recurring down
            // the right branch.
            if (root.left == null)
            {
                return MinDepth(root.right) + 1;
            }

            // If the right node is null, then we need to keep recurring down
            // the left branch.
            if (root.right == null)
            {
                return MinDepth(root.left) + 1;
            }

            // If there are left and right nodes, return the smaller of the minDepths
            // of the left and right, plus one to account for this root.
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
        #endregion

        #region HasPathSum
        /// <summary>
        /// Returns if a root-to-leaf summation exists int the given tree which equals the given integer.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool HasPathSum(TreeNode root, int sum)
        {
            // Handles the empty node.
            if (root == null)
            {
                return false;
            }

            // If both branches are null, we're at a leaf, and because we're working backwards to 
            // the target, this will only return true, if the sum of all the nodes traversed to get 
            // here is equal to the target.
            if (root.left == null && root.right == null)
            {
                return sum == root.val;
            }

            // Recursively call the left/right branches, passing in the current sum, minus the current
            // value of this node. 
            // Example, the target is 8, the first node's value is 2. We pass 6 into the left and 
            // right branches off this node.
            // On the left it's a leaf, has no left/right branch, so we return sum == val (6 == 4), 
            // which is false. 
            // On the right it's also a leaf, but the value is 6, so we return 6 == 6, true. 
            // We get back up to the first return statement, and the left call is false, but the 
            // right one is true, so we return true. 
            // The path taken to get the sum is root + right (2 + 6).
            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
        #endregion
    }
}
