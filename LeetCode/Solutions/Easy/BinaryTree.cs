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
    }
}
