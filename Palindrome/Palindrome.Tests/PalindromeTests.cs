using System;
using Xunit;
using Palindrome;

namespace Palindrome.Tests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("nurses run")]
        [InlineData("never odd, or even.")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("one two one")] // should fail
        public void CheckIfPalindromeIsValid2(string myString)
        {
            // arrange
            // let's test just one string first then use theory 
            var palindrome = new Palindrome();
            //var string1 = "nurses run";

            // act
            var result = palindrome.CheckPalindrome(myString);
            Console.WriteLine("result is" + result);
            // assert
            Assert.True(result);

        }
    }
}
