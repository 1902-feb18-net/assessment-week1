using System;
using Xunit;
using Assessment.Lib;

namespace Assessment.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even")]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void Test1(string test)
        {
            Palindrome Tester = new Palindrome(test);

            Assert.True(Tester.IsPalindrome());
        }
    }
}
