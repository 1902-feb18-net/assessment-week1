using System;
using System.Linq;
namespace Assessment.Library
{
    class Palindrome
    {
        public bool palindrome(string input)
        {
        var s1 = input.ToLower().Where(c => Char.IsLetter(c));
        var s2 = input.ToLower().Reverse().Where(c => Char.IsLetter(c));
        return s1.SequenceEqual(s2);
        }
    }
}
