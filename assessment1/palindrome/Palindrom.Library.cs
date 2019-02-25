using System;
using System.Collections.Generic;

namespace palindrome
{
    public class Palindrome
    {
        public bool isPalindrom(string input)
        {
            if (input == null || input == "")
                throw new ArgumentException("Cant have null or empty");
            input = input.ToLower();
            List<string> remList = new List<string>()
            {
                " ",
                ",",
                ".",
                "/",
                "?",
                ";",
                ":",
                @"\",
                "\"",
                "[",
                "]",
                "{",
                "}",
                "|",
            };
            for (int y = 0; y < remList.Count; y++)
            {
                if (input.Contains(remList[y]))
                {
                    input = input.Replace(remList[y], "");
                }
            }
            Console.WriteLine(input);
            string forward = "", backward = "";
            for(int a = 0; a < input.Length; a++)
            {
                forward = forward + input[a];
                backward = input[a] + backward;
            }
            Console.WriteLine(forward + " " + backward);
            if(forward.Equals(backward))
            {
                return true;
            }
            else
                return false;
        }
    }
}
