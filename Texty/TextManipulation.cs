using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texty
{
    class TextManipulation
    {
        public static IEnumerable<int> AllIndexesOf(string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    break;
                yield return index;
            }
        }

        public static IEnumerable<int> AllIndexesOfNoCase(string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index, StringComparison.CurrentCultureIgnoreCase);
                if (index == -1)
                    break;
                yield return index;
            }
        }
    }
}
