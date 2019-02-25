using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Library
{
    public class Palin
    {
        private string _first;
        private string _second;

        public string First
        { get => _first;
            set
            {
                _first = value;
            }
        }
        public string Second
        { get => _second;
          set
            {
                _second = value;
            }
        }

        public string Clean(string value)
        {
            value.ToLower();
            value.Replace(" ", string.Empty);
            value.Replace(",", string.Empty);
            value.Replace(".", string.Empty);
            value.Replace("-", string.Empty);
            value.Replace("?", string.Empty);
            value.Replace(";", string.Empty);
            value.Replace(":", string.Empty);
            return value;
        }

        public bool Drome()
        {
           string temp1 = Clean(_first);
           string temp2 = Clean(_second);

            temp1.Reverse();
            return temp1 == temp2;
        }
    }
}
