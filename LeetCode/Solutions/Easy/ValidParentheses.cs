using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Easy
{
    /// <summary>
    ///  class for solving Leetcode problem 20. Valid Parentheses
    /// </summary>
    /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    /// 
    /// An input string is valid if:
    /// Open brackets must be closed by the same type of brackets.
    /// Open brackets must be closed in the correct order.
    /// Every close bracket has a corresponding open bracket of the same type.
    /// 
    /// Example 1:
    /// Input: s = "()"
    /// Output: true
    /// Example 2:
    /// 
    /// Input: s = "()[]{}"
    /// Output: true
    /// Example 3:
    /// Input: s = "(]"
    /// Output: false
    /// 
    /// Constraints:
    /// 1 <= s.length <= 104
    /// s consists of parentheses only '()[]{}'
    /// 
    public class ValidParentheses
    {
        /// <summary>
        /// Parses a string a returns true if it's parentheses are in valid order.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                // is this c a (){}[]?
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }

                if (c == ')' || c == ']' || c == '}')
                {
                    // A close bracket without an open!
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    // Let's grab the last paren off the stack
                    char lastOpened = stack.Peek();

                    // If c doesn't match this, the string is invalid
                    switch (lastOpened)
                    {
                        case '(' when c == ')':
                            stack.Pop();
                            break;
                        case '[' when c == ']':
                            stack.Pop();
                            break;
                        case '{' when c == '}':
                            stack.Pop();
                            break;
                        default:
                            return false;
                    }
                }
            }

            // If the stack still contains a paren, then it hasn't been closed, 
            // and the string is invalid
            if (stack.Count > 0)
            {
                return false;
            }

            // If we've made it this far, we're valid! 
            return true;
        }
    }
}
