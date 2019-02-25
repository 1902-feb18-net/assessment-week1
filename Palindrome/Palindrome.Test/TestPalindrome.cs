using System;
using Xunit;
using Palindrome.Library;

namespace Palindrome.Test
{
    public class TestPalindrome
    {
        [Fact]
        public void NullStringShouldThrowNullException()
        {
            // Arrange
            IsPalindrome palindrome = new IsPalindrome();
            string s = null;

            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => palindrome.CheckIfPalindrome(s));
        }

        [Fact]
        public void EmptyStringShouldThrowException()
        {
            // Arrange
            IsPalindrome palindrome = new IsPalindrome();
            string s = "";

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => palindrome.CheckIfPalindrome(s));
        }

        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even")]
        public void APalindromeShouldReturnTrue(string val)
        {
            // Arrange
            IsPalindrome p = new IsPalindrome();
            string s = val;

            // Act
            var result = p.CheckIfPalindrome(s);

            // Assert
            Assert.True(result);
        }
    }
}
