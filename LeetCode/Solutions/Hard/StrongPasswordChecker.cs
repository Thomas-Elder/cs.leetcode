using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Hard
{
    /// <summary>
    /// A class for solving LeetCode problem 420. Strong Password Checker
    /// </summary>
    /// A password is considered strong if the below conditions are all met:
    /// It has at least 6 characters and at most 20 characters.
    /// It contains at least one lowercase letter, at least one uppercase letter, and at least one digit.
    /// It does not contain three repeating characters in a row(i.e., "...aaa..." is weak, but "...aa...a..." is strong, assuming other conditions are met).
    ///
    /// Given a string password, return the minimum number of steps required to make password strong. if password is already strong, return 0.
    /// 
    /// In one step, you can:
    /// - Insert one character to password,
    /// - Delete one character from password, or
    /// - Replace one character of password with another character.
    /// 
    /// Example 1:
    /// Input: password = "a"
    /// Output: 5
    /// 
    /// Example 2:
    /// Input: password = "aA1"
    /// Output: 3
    /// 
    /// Example 3:
    /// Input: password = "1337C0d3"
    /// Output: 0
    /// 
    /// Constraints:
    /// 1 <= password.length <= 50
    /// password consists of letters, digits, dot '.' or exclamation mark '!'.
    ///
    public class StrongPasswordChecker
    {
        /// <summary>
        /// Returns the number of steps needed to make the given string a strong password.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public int StepsToChange(string password)
        {
            int result = 0;

            // Basic flags
            bool length = false;
            bool upper = false;
            bool lower = false;
            bool number = false;

            // For tracking repeating characters
            char currentChar = ' ';
            int currentCharCount = 0;

            // Char array
            char[] passwordChar = password.ToCharArray();

            if (passwordChar.Length >= 6)
                length = true;

            foreach(char c in passwordChar)
            {
                // If we're looking at the currentChar, we increment the currentCharCount
                if (c.Equals(currentChar))
                {
                    currentCharCount++;
                }
                else
                {
                    // Once we've got a different char, if currentCharCount is not 2, we need to split up the chars
                    if (currentCharCount > 2)
                    {
                        // we can get the number of inserts
                        // required to split up any 3-somes by dividing by two, and taking the floor
                        // (eg 7 / 2 = 3.blahblah, so we need 3 inserts.
                        result += (int)Math.Floor(currentCharCount / 2.0);
                    }
                    
                    // Either way we now reset count and set char to this c.
                    currentCharCount = 1;
                    currentChar = c;
                }

                if (Char.IsUpper(c))
                    upper = true;

                if (Char.IsLower(c))
                    lower = true;

                if (Char.IsNumber(c))
                    number = true;
            }

            if (upper && lower && number)
            {
                if (passwordChar.Length < 5)
                    result += 6 - passwordChar.Length;
            }

            return result;
        }
    }
}
