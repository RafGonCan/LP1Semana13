using System;

namespace Palidrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string words in args)
            {
                if (words == null)
                {
                    Console.WriteLine("Error: Input cannot be null.");
                    continue;
                }

                bool result = IsPalindrome(words);
                Console.WriteLine($"{words} -> {result}");
            }
        }

        public static bool IsPalindrome(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word), "Input cannot be null.");
            }

            else if (word.Length < 2)
            {
                return true;
            }

            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            string reversedWord = new string(chars);

            return word == reversedWord;
        }
    }
}
