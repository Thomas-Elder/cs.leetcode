
namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving Leetcode problem 66. Plus One
    /// </summary>
    /// You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.
    /// The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
    /// Increment the large integer by one and return the resulting array of digits.
    /// 
    /// Example 1:
    /// Input: digits = [1,2,3]
    /// Output: [1,2,4]
    /// Explanation: The array represents the integer 123.
    /// Incrementing by one gives 123 + 1 = 124.
    /// Thus, the result should be[1, 2, 4].
    /// 
    /// Example 2:
    /// Input: digits = [4,3,2,1]
    /// Output: [4,3,2,2]
    /// Explanation: The array represents the integer 4321.
    /// Incrementing by one gives 4321 + 1 = 4322.
    /// Thus, the result should be[4, 3, 2, 2].
    /// 
    /// Example 3:
    /// Input: digits = [9]
    /// Output: [1,0]
    /// Explanation: The array represents the integer 9.
    /// Incrementing by one gives 9 + 1 = 10.
    /// Thus, the result should be[1, 0].
    /// 
    /// Constraints:
    /// 1 <= digits.length <= 100
    /// 0 <= digits[i] <= 9
    /// digits does not contain any leading 0's.
    /// 
    public class PlusOneProblem
    {
        /// <summary>
        /// PlusOne takes an array representing an integer and increments it by 1
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            int lastIndex = digits.Length - 1;

            // We need to work from the end of the array. 
            // If the least sig fig is <9, then we just add 1 and return.
            if (digits[lastIndex] < 9)
            {
                digits[lastIndex] = digits[lastIndex] + 1;
                return digits;
            }

            bool firstDigitNine = false;

            // Otherwise we need to work backwards from the end
            for (int i = lastIndex; i >= 0; i--)
            {

                // If this digit is 9, we need to do some stuff. 
                // If not, we can break from the loop, as the cascading of addition stops
                if (digits[i] == 9)
                {
                    // We set this index to 0
                    digits[i] = 0;
                    
                    // If we've got a 9 in the oth index, and we're still in this loop, it means
                    // we're looking at something like 999, and we'll need to make a longer array.
                    // We set a flag to check after the loop.
                    if (i == 0)
                    {
                        firstDigitNine = true;
                    } 
                    
                    // For any other index, if i - 1 is not 9, we can just increment that, and break
                    // from the loop. 
                    // If it is 9 we'll have to loop again.
                    else
                    {
                        if (digits[i - 1] != 9)
                        {
                            digits[i - 1]++;
                            break;
                        }
                    }

                } 
            }

            // So if firstDigitNine is true, we need to create an array 1 element longer than the input, set zeroth element
            // as 1, and then store all the zeros from the input array as subsequent elements. 
            if (firstDigitNine)
            {
                int [] largerDigits = new int [digits.Length + 1];
                largerDigits[0] = 1;
                System.Array.Copy(digits, 0, largerDigits, 1, digits.Length);

                digits = largerDigits;
            }

            return digits;
        }
    }
}
