using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Texty
{
    class TextManipulation
    {
        public static List<int> AllIndexesOf(string str, string value)
        {
            List<int> indexes = new List<int>();
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            for (int index = 0; index < str.Length; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    break;
                indexes.Add(index);
            }
            return indexes;
        }

        public static List<int> AllIndexesOfNoCase(string str, string value)
        {
            List<int> indexes = new List<int>();
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            for (int index = 0; index < str.Length; index += value.Length)
            {
                index = str.IndexOf(value, index, StringComparison.CurrentCultureIgnoreCase);
                if (index == -1)
                    break;
                indexes.Add(index);
            }
            return indexes;
        }
    }
}
