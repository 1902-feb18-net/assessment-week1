using System;
using System.Collections.Generic;
using System.Text;

namespace Pal.UnitTest
{
    class pal
    {
        public bool palindrome(string text)
        {
            int size = 0;
            List<char> textValues = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' || text[i] == ',' || text[i] == '.')
              
                { }
                else
                {
                    textValues.Add(char.ToLower(text[i]));
                    size++;
                }
            }
            for (int i = 0; i < size / 2; i++)
            {
                if (textValues[i] == textValues[size - 1 - i])
                { }
                else
                    return false;
            }
            return true;
        }
    }
}