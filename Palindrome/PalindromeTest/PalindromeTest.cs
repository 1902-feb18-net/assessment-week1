using System;
using Xunit;
using PalindromeLibrary;

namespace PalindromeTest
{
    public class PalindromeTest
    {
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even")]
        public void TestingPalindromeSuccessMultipleInputs(string input)
        {
            Assert.True(StrPalindrome.CheckPalindrome(input));
        }

        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void TestingPalindromeFailureMultipleInputs(string input)
        {
            Assert.False(StrPalindrome.CheckPalindrome(input));
        }
    }
}
