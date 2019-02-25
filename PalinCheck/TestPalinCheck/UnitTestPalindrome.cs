using PalinCheck;
using System;
using Xunit;

namespace TestPalinCheck
{
    public class UnitTestPalindrome
    {
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even.")]
        public void IsPalindrome(string value)
        {
            var checkstring = new checkString();
            bool flag = checkstring.check(value);

            Assert.True(flag);

        }

        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void IsNotPalindrome(string value)
        {
            var checkstring = new checkString();
            bool flag = checkstring.check(value);

            Assert.False(flag);

        }
    }
}
