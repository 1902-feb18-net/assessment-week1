using System;
using System.Linq;

namespace Palindromes.Library
{
    public class Palindrom
    {
        public bool ISAPalindrome(string pal)
        {
            pal = pal.Replace(" ", "");
            pal = pal.Replace(".", "");
            pal = pal.Replace(",", "");
            pal = pal.ToLower();
            return pal.SequenceEqual(pal.Reverse());
        }
    }
}
