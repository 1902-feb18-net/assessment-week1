using Palindrome.Library;

using Xunit;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even.")]
        public void StringIsPalindrome(string param)
        {
            //Arrange
            Class1 obj = new Class1();
            //Act
            var result = obj.PalindromeCheck(param);
            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void StringIsNotPalindrome(string param)
        {
            //Arrange
            Class1 obj = new Class1();
            //Act
            var result = obj.PalindromeCheck(param);
            //Assert
            Assert.False(result);
        }



    }
}
