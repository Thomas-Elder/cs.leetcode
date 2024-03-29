﻿using System;
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
            // Basic flags
            bool upper = false;
            bool lower = false;
            bool number = false;

            // For tracking repeating characters
            char currentChar = ' ';
            int currentCharCount = 0;
            int repeatingCharacterSeparators = 0;

            // Char array
            char[] passwordChar = password.ToCharArray();

            foreach (char c in passwordChar)
            {
                // If we're looking at the currentChar, we increment the currentCharCount
                if (c.Equals(currentChar))
                {
                    currentCharCount++;
                }
                else
                {
                    // Once we've got a different char, if currentCharCount is greater than 2, then we need to break up 
                    // a three some by inserting some characters.
                    if (currentCharCount > 2)
                    {
                        // We can get the number of inserts required to split up any 3-somes by dividing by 3,
                        // and taking the floor of the result... 
                        // (eg 7 / 3 = 2.blahblah, so we need 2 replacements.
                        repeatingCharacterSeparators += (int)Math.Floor(currentCharCount / 3.0);
                    }

                    // Either way we now reset count and set char to this c.
                    currentCharCount = 1;
                    currentChar = c;
                }

                // Check if this character is upper/lower/number and set flag to true.
                if (Char.IsUpper(c))
                    upper = true;

                if (Char.IsLower(c))
                    lower = true;

                if (Char.IsNumber(c))
                    number = true;
            }

            // If the last 3+ characters were identical then we need to handle the splitting of them here:
            if (currentCharCount > 2)
            {
                repeatingCharacterSeparators += (int)Math.Floor(currentCharCount / 3.0);
            }

            // How many characters required to reach the min length requirement...
            int lengthRequired = 6 - passwordChar.Length;

            // How many deletions for the max length requirement
            int lengthReduction = passwordChar.Length > 20 ? passwordChar.Length - 20 : 0;

            // How many characters required to meet the special character requirement... 
            int charactersRequired = 0;
            charactersRequired += upper ? 0 : 1;
            charactersRequired += lower ? 0 : 1;
            charactersRequired += number ? 0 : 1;

            // Now we know how many characters we need for each requirement, and since adding one 
            // character can meet all the requirements (ie it could increase the length, break up 
            // repeating characters, and be a required character type), we just need the 
            // maximum required characters from the different requirements. 
            // Aaaaand add
            return Math.Max(charactersRequired, Math.Max(lengthRequired, repeatingCharacterSeparators)) + lengthReduction;
        }
    }
}
