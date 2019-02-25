using System;

namespace PalinCheck
{
    public class checkString
    {

        public bool check(string inputString)
        {
            string result = "";
            foreach (var item in inputString)
            {
                result = item + result;
            }

            if (inputString == result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
