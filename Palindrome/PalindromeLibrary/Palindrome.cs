using System;

namespace PalindromeLibrary
{
    public static class Palindrome
    {
        public static bool CheckPalindrome(string input)
        {
            // Get rid of whitespace
            // http://net-informations.com/q/faq/remove.html
            string output = input.Replace(" ", String.Empty);
            output = output.Replace(",", String.Empty);
            output = output.Replace(".", String.Empty);


            // Now try and reverse the string
            // https://www.tutorialspoint.com/Chash-program-to-check-if-a-string-is-palindrome-or-not
            char[] ch = output.ToCharArray();

            Array.Reverse(ch);
            string reversed = new string(ch);


            return output.Equals(reversed, StringComparison.OrdinalIgnoreCase);

        }
    }
}
