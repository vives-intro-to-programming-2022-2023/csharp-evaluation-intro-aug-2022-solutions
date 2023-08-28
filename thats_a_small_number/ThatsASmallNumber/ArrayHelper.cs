using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThatsASmallNumber
{
    public class ArrayHelper
    {
        public int SmallestValue(int[] values)
        {
            // TODO Zoek de kleinste waarde in de array en geef de waarde terug
            // TODO Indien values null of leeg is dien je 0 terug te geven
            // TODO Zorg dat het ook werkt voor negatieve getallen

            int iSmallest = SmallestIndex(values);
            if (iSmallest == -1) return 0;

            return values[iSmallest];
        }

        public int SmallestIndex(int[] values)
        {
            // TODO Zoek de index van de kleinste waarde in de array en geef de waarde terug
            // TODO Indien values null of leeg is dien je -1 terug te geven
            // TODO Zorg dat het ook werkt voor negatieve getallen

            if (values == null || values.Length == 0) return -1;

            int iSmallest = 0;
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < values[iSmallest])
                {
                    iSmallest = i;
                }
            }

            return iSmallest;
        }
    }
}
