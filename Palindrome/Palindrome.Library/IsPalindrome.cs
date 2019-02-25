using System;

namespace Palindrome.Library
{
    public class IsPalindrome
    {
        public bool CheckIfPalindrome(string s)
        {
            string check = "";

            if(s.Equals(null))
            {
                throw new ArgumentNullException("String cannot be null.", nameof(s);
            }

            foreach (char c in s)
            {
                check = s + check;
            }

            if (s.Equals(check)) return true;

            return false;
        }
    }
}
