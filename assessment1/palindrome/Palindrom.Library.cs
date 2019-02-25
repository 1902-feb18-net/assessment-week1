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
            List<char> inputList = new List<char>();
            List<char> remList = new List<char>()
            {
                ' ', ',', '.', '/', '?', ';', ':', '\'', '"', '[', ']', '{', '}', '|' 
            };
            foreach(int x in input)
            {
                inputList[x] = input[x];
            }
            foreach (int y in remList)
            {
                input.Remove(remList[y]);
            }
            string forward = "", backward = "";
            for(int a = 0; a < inputList.Capacity; a++)
            {
                forward = forward + inputList[a];
                backward = inputList[a] + backward;
            }
            if(forward == backward)
            {
                return true;
            }
            else
                return false;
        }
    }
}
