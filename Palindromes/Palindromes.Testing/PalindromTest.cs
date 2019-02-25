using System;
using Xunit;

namespace Palindromes.Testing
{
    public class PalindromTest
    {
        [Theory]
        [InlineData ("racecaR")]
        [InlineData ("1221")]
        [InlineData ("never odd, or even.")]
        [InlineData ("nurses run")]
        public void IsPalindrome(string data)
        {
            var pal = new Palindrome();
            Assert.True(IsAPalindrome(data));
        }


        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void IsNotPalindrome(string data)
        {

        }