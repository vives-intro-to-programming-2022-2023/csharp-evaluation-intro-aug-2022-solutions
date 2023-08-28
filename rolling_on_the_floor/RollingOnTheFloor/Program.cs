using System;

namespace AbbreviateThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rolling on the Floor ...");

            Abbreviator abbr = new Abbreviator();

            string text = "League of Legends";
            Console.WriteLine($"{text} can be abbreviated to {abbr.Abbreviate(text)}");
        }
    }
}
