using System;
using System.Linq;

namespace Palindrome.Library
{
    public class IsPalindrome
    {
        public bool CheckIfPalindrome(string s)
        {
            string check = "";
            string temp = new string(s);

            temp.ToLower();

            if(temp.Contains(" "))
                temp.Replace(" ","");
            if(temp.Contains(","))
                temp.Replace(",", "");

            if(s.Equals(null))
            {
                throw new ArgumentNullException("String cannot be null.", nameof(s));
            }

            foreach (char c in temp)
            {
                check = temp + check;
            }

            if (s.Equals(check)) return true;

            return false;
        }
    }
}
