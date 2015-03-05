using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texty
{
    class Indentation
    {
        static string spaces = "";

        public static void ExtractSpaces(string line)
        {
            int i = 0;
            spaces = "";
            while (i < line.Length && (line[i] == ' ' || (int)line[i] == 9))
            {
                spaces += line[i];
                ++i;
            }
        }

        public static string GetSpaces()
        {
            string temp = String.Copy(spaces);
            spaces = "";
            return temp;
        }

        public static bool ToIndent()
        {
            return spaces.Length > 0;
        }
    }
}
