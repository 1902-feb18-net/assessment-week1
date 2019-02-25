using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    public class Palindrome
    {
        public bool CheckPalindrome (string myString)
        {
            string newString = myString.ToLower();
            newString = Regex.Replace(newString, "[^\\w\\.]", "");

            for (int i = 0; i < newString.Length / 2; i++)
            {
                if(newString[i] != newString[myString.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
