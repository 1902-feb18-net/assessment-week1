using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    public class Palindrome
    {
        public bool CheckPalindrome (string myString)
        {
            // lower case string
            string newString = myString.ToLower();
            newString = newString.Replace(" ", String.Empty);
            // attempts to remove all special characters
            newString = Regex.Replace(newString, @"[^0-9a-zA-Z]+", "");

            for (int i = 0; i < newString.Length / 2; i++)
            {
                if(newString[i] != newString[newString.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
