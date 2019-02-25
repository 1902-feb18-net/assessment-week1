using Project.Library;
using System;
using Xunit;

namespace assessment_week1{

    class PalindromeTest{

        [Fact]
        public void IsATruePalindrome()
        {
            //Arrange
            var word = new Palindrome();

            //Act
            word.Equals("racecaR");

            //Assert
            Assert.True(result);

        }

        [Fact]
        public void NotAPalindrome()
        {
            //Arrange
            var word = new Palindrome();

            //Act
            word.Equals("123abccba123");

            //Assert
            Assert.False(result);

        }
        
    }
}