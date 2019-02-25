using PalinCheck;
using System;
using Xunit;

namespace TestPalinCheck
{
    public class UnitTestPalindrome
    {
        [Fact]
        public void IsPalindrome()
        {
            var checkstring = new checkString();
            bool flag = checkstring.check("never odd, or even.");

            Assert.True(flag);

        }

        [Fact]
        public void IsNotPalindrome()
        {
            var checkstring = new checkString();
            bool flag = checkstring.check("123abccba123");

            Assert.False(flag);

        }
    }
}
