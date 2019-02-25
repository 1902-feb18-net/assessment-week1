using System;
using Xunit;
using Palindrome;

namespace Palindrome.Tests
{
    public class PalindromeTests
    {
        [Fact]
        public void CheckIfPalindromeIsValid()
        {
            // arrange
            // let's test just one string first then use theory 
            var palindrome = new Palindrome();
            var string1 = "nurses run";

            // act
            var result = palindrome.CheckPalindrome(string1);
            Console.WriteLine("result is" + result);
            // assert
            Assert.True(result);

        }
    }
}
