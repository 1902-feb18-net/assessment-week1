using System;

namespace assessment_week1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string initialString;
            Console.Write("Enter a string to be checked if it is a palindrome:");
            
            initialString = Console.ReadLine();   
            char[] stringArray = initialString.ToCharArray();
            
            string test = String.Empty;

            for(int i = stringArray.Length -1; i > -1; i--)
            {
                test += stringArray[i];
            }
            // Console.WriteLine(test);

            if (test == initialString)
                {
                    Console.WriteLine($"{initialString} is a palindrome");
                }
            else
            {
                Console.WriteLine($"{initialString} is not a palindrome");               
            }
            
           

        }
    }
}
