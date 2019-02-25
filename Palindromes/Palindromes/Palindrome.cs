using System;
using System.Linq;

namespace Palindromes.Library
{
    public class Palindromes
    {
        static public bool ISAPalindrome(string pal)
        {
            return pal.SequenceEqual(pal.Reverse());
        }
    }
}
