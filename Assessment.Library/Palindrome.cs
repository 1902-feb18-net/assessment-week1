using System;
using System.Linq;
namespace Assessment.Library
{
    class Palindrome
    {
        public bool palindrome(string input)
        {
            int x = 0; 
            int y = input.Length - 1; 
        
        input = input.ToLower(); 

        while(x <= y) 
        { 
            char charX = input[x]; 
            char charY = input[y]; 

            if (!(charX >= 'a' &&  
                  charY <= 'z')) 
                x++; 

            else if(! (charY >= 'a' && 
                       charX <= 'z')) 
                y--; 

            else if( charX == charY) 
            { 
                x++; 
                y--; 
            } 

            else
                return false;
        }

            return true;
        }
    }
}
