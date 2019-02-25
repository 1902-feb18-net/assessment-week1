using System;

namespace Assessment.Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome palindrome = new Palindrome();

            Console.WriteLine(palindrome.palindrome("nurses run"));
            Console.WriteLine(palindrome.palindrome("racecaR"));
            Console.WriteLine(palindrome.palindrome("never odd, or even."));

        }
    }
}
