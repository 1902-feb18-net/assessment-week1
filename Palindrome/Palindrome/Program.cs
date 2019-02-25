using System;
using PalindromeLibrary;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "nurses run";
            string input2 = "racecaR";
            string input3 = "1221";
            string input4 = "never odd, or even";
            string input5 = "one two one";
            string input6 = "123abccba123";

            var result1 = PalindromeLibrary.Palindrome.CheckPalindrome(input1);
            Console.WriteLine(result1);
            var result2 = PalindromeLibrary.Palindrome.CheckPalindrome(input2);
            Console.WriteLine(result2);
            var result3 = PalindromeLibrary.Palindrome.CheckPalindrome(input3);
            Console.WriteLine(result3);
            var result4 = PalindromeLibrary.Palindrome.CheckPalindrome(input4);
            Console.WriteLine(result4);
            var result5 = PalindromeLibrary.Palindrome.CheckPalindrome(input5);
            Console.WriteLine(result5);
            var result6 = PalindromeLibrary.Palindrome.CheckPalindrome(input6);
            Console.WriteLine(result6);



        }
    }
}
