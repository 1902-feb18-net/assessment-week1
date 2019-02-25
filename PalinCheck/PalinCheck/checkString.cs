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

            if (inputString.ToLower().Replace(" ","").Replace(".","").Replace(",","") 
                == result.ToLower().Replace(" ", "").Replace(".", "").Replace(",", ""))
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
