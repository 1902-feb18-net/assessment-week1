using System;
using System.Linq;
using Xunit;
using Palindrome.Library;

namespace PalindromeTest.Test
{
    public class UnitTest1
    {
        readonly Palin palindrome = new Palin();

        [Fact]
        public void Return_True_for_First_Allocation()
        {
            const string tFirst = "william";
            palindrome.First = tFirst;
            bool result = palindrome.First == tFirst;
            Assert.True(result, "I should be True");

        }

        [Fact]
        public void Return_True_for_Second_Allocation()
        {
            const string tSecond = "mailliw";
            palindrome.Second = tSecond;
            bool result = palindrome.Second == tSecond;
            Assert.True(result, "I should be True");
        }

        [Fact]
        public void Return_True_for_Palindrome()
        {
            Assert.True(palindrome.Drome(), "I should be True");
        }

        [Fact]
        public void Return_False_for_Comparison()
        {
            palindrome.Second = "mail liw.";
            string temp = palindrome.Clean(palindrome.Second);

            bool result = temp == palindrome.Second;
            Assert.True(result, "I should be False");
        }
    }

}
