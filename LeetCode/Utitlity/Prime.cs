using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    public class Prime
    {
        /// <summary>
        /// Checks n for primeness
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPrime(int n)
        {

            // Handle trivial cases 
            if (n.Equals(2) || n.Equals(3)) { return true; }
            else if (n <= 1 || (n % 2).Equals(0) || (n % 3).Equals(0)) { return false; }

            // Then we can start at 5, and run til sqrt(n), anything higher we run into the 
            // complementary factors of one's we've already found. 
            for (int i = 5; i <= Math.Sqrt(n); i += 6)
            {
                if ((n % i).Equals(0) || (n % (i + 2)).Equals(0))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks n for primeness
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPrime(long n)
        {

            // Handle trivial cases 
            if (n.Equals(2) || n.Equals(3) || n.Equals(5)) { return true; }
            else if (n <= 1 || (n % 2).Equals(0) || (n % 3).Equals(0)) { return false; }

            // Then we can start at 5, and run til sqrt(n), anything higher we run into the 
            // complementary factors of one's we've already found. 
            for (int i = 5; i <= Math.Sqrt(n); i += 6)
            {
                if ((n % i).Equals(0) || (n % (i + 2)).Equals(0))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
