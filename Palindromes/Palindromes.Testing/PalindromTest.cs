using System;
using Xunit;
using Palindromes.Library;

namespace Palindromes.Testing
{
    public class PalindromTest
    {
        [Theory]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even.")]
        [InlineData("nurses run")]
        public void IsPalindrome(string data)
        {
            var pal = new Palindrom();
            Assert.True(pal.ISAPalindrome(data));
        }


        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void IsNotPalindrome(string data)
        {
            var pal = new Palindrom();

            Assert.False(pal.ISAPalindrome(data));
        }
    }
}