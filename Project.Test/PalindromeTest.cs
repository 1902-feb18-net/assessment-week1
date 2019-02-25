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

        }

        [Fact]
        public void NotAPalindrome()
        {
            //Arrange
            
            //Assert

        }
        
    }
}