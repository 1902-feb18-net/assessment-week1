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
            Clean(_first);
            Clean(_second);

            _first.Reverse();
            return _first == _second;
        }
    }
}
