using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Palindrome");
            Console.Write("Please enter a text to check: ");
            string text = Console.ReadLine();

            PalindromeChecker checker = new PalindromeChecker();
            bool isPalindrome = checker.IsPalindrome(text);

            Console.WriteLine($"\n\"{text}\" is{(isPalindrome ? "" : " not")} a palindrome");
        }
    }
}
