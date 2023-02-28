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
        public virtual bool IsSameTreeRecursive(TreeNode p, TreeNode q)
        {
            // 1. both empty
            if (p == null && q == null)
            {
                return true;
            }

            // 2. both non-empty -> compare them
            if (p != null && q != null)
            {
                return (p.val == q.val
                        && IsSameTreeRecursive(p.left, q.left)
                        && IsSameTreeRecursive(p.right, q.right));
            }

            // 3. one empty, one not -> false 
            return false;
        }
    }
}
