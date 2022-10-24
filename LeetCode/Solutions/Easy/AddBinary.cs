
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

            char [] aChars = a.ToCharArray();
            char [] bChars = b.ToCharArray();

            int resultLength = aChars.Length > bChars.Length ? aChars.Length : bChars.Length;

            char [] resultChars = new char[resultLength];

            int carry = 0;

            // Looping
            // We need to start at the end of both strings, working backward
            int aIndex = aChars.Length - 1;
            int bIndex = bChars.Length - 1;
            int resultIndex = resultLength - 1;

            while (aIndex >= 0 || bIndex >= 0)
            {
                int sum = 0;
                sum += aIndex >= 0 ? a[aIndex--] - '0' : 0;
                sum += bIndex >= 0 ? b[bIndex--] - '0' : 0;
                sum += carry;

                if (sum > 2)
                {
                    resultChars[resultIndex--] = '1';
                    carry = 1;
                }
                else if (sum > 1) 
                { 
                    resultChars[resultIndex--] = '0';
                    carry = 1;
                } 
                else
                {
                    resultChars[resultIndex--] = sum == 1 ? '1' : '0';
                    carry = 0;
                }
            }

            string result = new string(resultChars);

            if (carry == 1)
            {
                // we'll need an extra digit on the front, this is easier when it's a string! 
                result = result.Insert(0, "1");
            }

            return result;
        }
    }
}
