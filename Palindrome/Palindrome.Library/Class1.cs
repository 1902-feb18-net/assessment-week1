using System;
using System.Text.RegularExpressions;

namespace Palindrome.Library
{
    //Class for checking if given input string is a palindrome, 
    //a string the same backwards as forwards,
    //ignoring case sensitivity, special characters and whitespaces
    public class Class1
    {
        Regex character = new Regex(@"[a-z0-9]"); 
        string reverse;
        string forward;

        public bool PalindromeCheck(string input) //checks if input string is a palindrome
        {
            reverse = "";
            forward = "";

            foreach (char item in input.ToLower())
            {
                if (character.IsMatch(item.ToString()) )
                {
                    forward = forward + item; //append
                    reverse = item + reverse; //prepend
                }               
            }

            return (forward == reverse);  //if they are the same, string is palindrome
        }
    }
}
