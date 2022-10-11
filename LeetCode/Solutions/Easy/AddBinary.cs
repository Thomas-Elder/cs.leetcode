
namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving leetcode problem 67. Add Binary
    /// </summary>
    /// Given two binary strings a and b, return their sum as a binary string.
    /// 
    /// Example 1:
    /// Input: a = "11", b = "1"
    /// Output: "100"
    /// 
    /// Example 2:
    /// Input: a = "1010", b = "1011"
    /// Output: "10101"
    /// 
    /// Constraints:
    /// 1 <= a.length, b.length <= 104
    /// a and b consist only of '0' or '1' characters.
    /// Each string does not contain leading zeros except for the zero itself.
    public class AddBinary
    {
        public string AddBinaryStrings(string a, string b)
        {
            // Trivial cases
            if (a == b && a == "0")
            {
                return "0";
            }

            // Looping
            // We need to start at the end of both strings, working backward
            string result = "";
            string carry = "0";

            while (a.Length > 0 || b.Length > 0)
            {

                string currA = a.Substring(a.Length - 1);
                a = a.Remove(a.Length - 1);

                string currB = b.Substring(b.Length - 1);
                b = b.Remove(b.Length - 1);

                if (currA == currB && currA == "1")
                {
                    result = result.Insert(0, "0");
                    carry = "1";
                }

                if (currA == currB && currA == "0")
                {
                    if (carry == "1")
                    {
                        result = result.Insert(0, "1");
                        carry = "0";
                    }

                    result = result.Insert(0, "0");
                }

                if (currA != currB)
                {
                    result = result.Insert(0, "1");
                    carry = "0";
                }
            }
            
            if (carry == "1")
            {
                result.Insert(0, "1");
            }

            return result;
        }
    }
}
