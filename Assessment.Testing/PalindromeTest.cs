using System;
using Assessment.Library;
using Xunit;

namespace Assessment.Testing
{
    public class PalindromeTest
    {
        public void Input_NotEmpty()
        {
            Assert.ThrowsAny<ArgumentException>(() => Palindrome.palindrome = string.Empty);
        }
    }
}
