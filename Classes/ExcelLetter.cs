using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelSplitter
{
    public class ExcelLetter
    {
        public Dictionary<string, int> Letters { get; set; } = new Dictionary<string, int>();
        public ExcelLetter()
        {
            for (int symbolASCII = 65, index = 1; symbolASCII <= 90; symbolASCII++, index++)
                Letters.Add(Convert.ToChar(symbolASCII).ToString(), index);
        }

        public int GetNumber(string letter)
        {
            letter = new string(letter.ToCharArray().Where(n => !char.IsDigit(n)).ToArray());
            return letter.Length > 1 ? 26 : Letters[letter];
        }

        public string GetLetter(int number)
        {
            foreach (KeyValuePair<string, int> entry in Letters)
                if (number == entry.Value)
                    return entry.Key;

            return "";
        }
    }
}
