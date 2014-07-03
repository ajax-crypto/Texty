using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace Texty
{
    class CodeHighlighter
    {
        public static Dictionary<int, int> GetIndexes(String text, String[] keywords)
        {
            Dictionary<int, int> indexes = new Dictionary<int, int>();
            int index = 0, start = 0;
            char prev = 'a';
            String keyword = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c) || char.IsNumber(c))
                {
                    if (!char.IsLetter(prev) && !char.IsNumber(prev))
                        start = index;
                    keyword += c;
                }
                else
                {
                    foreach (String word in keywords)
                    {
                        if (keyword.Equals(word))
                            indexes.Add(start, keyword.Length);
                    }
                    keyword = "";
                }
                ++index;
                prev = c;
            }
            return indexes;
        }
    }
}
