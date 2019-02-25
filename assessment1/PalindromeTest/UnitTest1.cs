using System;
using Xunit;
using palindrome;

namespace PalindromeTest
{
    public class UnitTest1
    {
        public string test;
        [Fact]
        public void TestPalidromeWithNothing()
        {
            test = "asdfdsa";
            var pal = new Palindrome();
            Assert.True(pal.isPalindrom(test));
        }
        [Fact]
        public void TestPalidromeWithSpace()
        {
            test = "asd fdsa";
            var pal = new Palindrome();
            Assert.True(pal.isPalindrom(test));
        }
        [Fact]
        public void TestPalidromeWithPunctuation()
        {
            test = "asdf,dsa";
            var pal = new Palindrome();
            Assert.True(pal.isPalindrom(test));
        }
        [Fact]
        public void TestPalidromeWithCapitals()
        {
            test = "aSdfDsa";
            var pal = new Palindrome();
            Assert.True(pal.isPalindrom(test));
        }
    }
}
