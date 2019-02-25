using System;

namespace assessment_week1
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            while(false)
            {
                Console.WriteLine("Enter a word to check if Palindrome:");
                string w = Console.ReadLine();
                checkPalindrome(w);

            }


        }

        public bool checkPalindrome(string word){
            

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = word.Length - 1; j > 0; j--)
                {
                    if (i == j)
                    {
                        if (word[i] != word[j])
                        {
                            return false;
                        }
                        else
                        {return true;}
                    }
                    else
                    {
                        if (word[i] != word[j])
                        {
                            return false;
                        }
                    }
                }

            }
            return false;
        }
    }
}
