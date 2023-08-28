using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string text)
        {
            // TODO Geef true terug als text een palindroom is
            // TODO Hoofdletters zijn hetzelfde als kleine letters
            // TODO Alle leestekens mag je negeren, spaties inbegrepen
            // TODO Indien text leeg is of null dien je false terug te geven

            if (text == null || text.Trim() == "") return false;

            text = text.Trim().ToLower();

            string cleanText = "";
            string reversed = "";
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= 'a' && text[i] <= 'z') || (text[i] >= '0' && text[i] <= '9'))
                {
                    cleanText = cleanText + text[i];
                    reversed = text[i] + reversed;
                }
            }

            return cleanText == reversed;
        }
    }
}
