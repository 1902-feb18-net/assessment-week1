using System;
using System.Linq;

namespace Palindromes
{
    public class Palindrome
    {
        static public bool ISAPalindrome(string pal)
        {
            return pal.SequenceEqual(pal.Reverse());
        }
    }
}
