using palindrome;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pal = new Palindrome();
            string test = "asd fdsa";
            Console.WriteLine(pal.isPalindrom(test));
        }
    }
}
