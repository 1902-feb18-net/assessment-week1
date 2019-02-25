using System;
using System.Text.RegularExpressions;

namespace Palindrome.Library
{
    public class Class1
    {
        Regex letter = new Regex(@"[a-z0-9]");
        string reverse;
        string forward;

        public bool PalindromeCheck(string input)
        {
            reverse = "";
            forward = "";

            foreach (char item in input.ToLower())
            {
                if (letter.IsMatch(item.ToString()) )
                {
                    forward = forward + item; //append
                    reverse = item + reverse; //prepend
                }               
            }

            return (forward == reverse);
        }
    }
}
