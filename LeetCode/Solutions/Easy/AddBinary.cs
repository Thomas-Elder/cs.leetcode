
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
    /// 
    /// Passing leetcode
    public class AddBinary
    {
        public string AddBinaryStrings(string a, string b)
        {
            // Trivial cases
            if (a == b && a == "0")
            {
                return "0";
            }

            int resultLength = a.Length > b.Length ? a.Length : b.Length;

            char [] resultChars = new char[resultLength];

            int carry = 0;
         
            int aIndex = a.Length - 1;
            int bIndex = b.Length - 1;
            int resultIndex = resultLength - 1;

            // Looping
            // We need to start at the end of both strings, working backward
            while (aIndex >= 0 || bIndex >= 0)
            {
                int sum = 0;

                // OK this is the tricky bit. 
                // First we check if the index is valid (ie >= 0).
                // Then if it's valid we add the char - '0' to the sum.
                // What happens here is when you index a string, it returns a char. When we subtract a char from a char, 
                // this gets handled as if they were the ascii integer representations of that char.
                // '0' is 48, and '1' is 49. 
                // So when a[index] is '1' for example, and we subtract '0' from it, we're actually doing: 49 - 48 = 1,
                // and adding that to the sum. And '0' - '0' = 0.
                sum += aIndex >= 0 ? a[aIndex--] - '0' : 0;
                sum += bIndex >= 0 ? b[bIndex--] - '0' : 0;

                // Add any carry from a previous loop if needed.
                sum += carry;

                // If the sum is 3, we need to add 11, which is 1 now, and a carry
                if (sum > 2)
                {
                    resultChars[resultIndex--] = '1';
                    carry = 1;
                }
                // If the sum is 2, we need to add 10, which is 0 now, and a carry
                else if (sum > 1) 
                { 
                    resultChars[resultIndex--] = '0';
                    carry = 1;
                } 
                // If the sum is 0 or 1, we can just add that, and the carry is zero
                else
                {
                    resultChars[resultIndex--] = sum == 1 ? '1' : '0';
                    carry = 0;
                }
            }

            // We need to convert to a string to return
            string result = new string(resultChars);

            // If we've still got a carry, we need to insert it at the beginning, which is easier to do after
            // converting the result to a string
            if (carry == 1)
            {
                result = result.Insert(0, "1");
            }

            return result;
        }
    }
}
