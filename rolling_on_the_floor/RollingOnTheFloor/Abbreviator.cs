using System;
using System.Collections.Generic;
using System.Text;

namespace AbbreviateThis
{
    public class Abbreviator
    {
        public string Abbreviate(string text)
        {
            // TODO Converteer text naar een afkorting
            // TODO Zorg ervoor dat het eindresultaat alleen hoofdletters bevat
            // TODO Als text leeg is, dan moet het resultaat een lege string zijn
            // TODO Als text null is, dan moet het resultaat een lege string zijn

            if (text == null || text.Length == 0) return "";

            text = text.Trim();
            string output = "" + text[0];
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i - 1] == ' ')
                {
                    output += text[i];
                }
            }

            return output.ToUpper();
        }
    }
}
