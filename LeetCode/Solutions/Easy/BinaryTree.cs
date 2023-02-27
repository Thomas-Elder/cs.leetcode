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
    }
}
