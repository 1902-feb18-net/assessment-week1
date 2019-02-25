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

            if (s == null)
            {
                throw new ArgumentNullException("String must not be null.", nameof(s));
            }
            else if(s == "")
            {
                throw new ArgumentException("String must not be empty", nameof(s));
            }

            temp = temp.ToLower();


            if (temp.Contains(" "))
                temp.Replace(" ", "");
            if (temp.Contains(","))
                temp.Replace(",", "");
            

            foreach (char c in temp)
            {
                check = c + check;
            }

            if (temp.Equals(check)) return true;

            return false;
        }
    }
}
