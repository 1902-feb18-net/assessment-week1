using System;
using System.Linq;
using System.Text.RegularExpressions;

//code in branch named according to your first name, lowercase.
//two projects, a library project and a unit test project.
//library should have a class that can tell me whether a string is a palindrome or not.
//all the behavior of the class should be unit tested.
//a palindrome reads the same forwards and backwards.
//these should be considered palindromes:
//    "nurses run"
//    "racecaR"
//    "1221"
//    "never odd, or even."
//these should not be considered palindromes:
//    "one two one"
//    "123abccba123"
//follow best practices.


namespace Assessment.Lib
{
    public class Palindrome
    {
        public Palindrome(string s)
        {
            Input = s;
        }

        public bool IsPalindrome()
        {

            Input = Input.Replace(" ", String.Empty);
            Input = Input.Replace(",", String.Empty);
            Input = Input.ToLower();

            //char[] inputChar = Input.ToCharArray();
            //inputChar = Array.FindAll(inputChar, c => char.IsLetterOrDigit(c));
            //Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            //Input = rgx.Replace(Input, "");
            //for (int i = 0; i < Input.Length; i++) //checks for characters outside of A-Z and a-z, and replaces them with ""
            //{
            //    if (!(Input[i] >= 65 && Input[i] <= 90 || Input[i] >= 97 && Input[i] <= 122))
            //    {
            //        string str = Input[i].ToString();
            //        Input = Input.Replace(str, String.Empty);
            //    }
            //}

            char[] arr = Input.ToCharArray();
            Array.Reverse(arr);

            //return inputChar == inputChar.Reverse();
            return Input.SequenceEqual(arr);
        }

        string Input { get; set; }
    }
}
