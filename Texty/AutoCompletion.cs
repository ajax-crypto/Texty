using System;
using System.Collections.Generic;

namespace Texty
{
    class AutoCompletion
    {
        public static string[] ClosingChar = { ")", "}", "]", "\"", "'" };

        public const int FIRST_BRACKET = 0;
        public const int SECOND_BRACKET = 1;
        public const int THIRD_BRACKET = 2;
        public const int STRING = 3;
        public const int CHARACTER = 4;

        static int close;
        public static bool ToClose;

        public static void Opened(char ch)
        {
            switch (ch)
            {
                case '{':
                    close = SECOND_BRACKET;
                    ToClose = true;
                    break;
                case '(':
                    close = FIRST_BRACKET;
                    ToClose = true;
                    break;
                case '[':
                    close = THIRD_BRACKET;
                    ToClose = true;
                    break;
                case '"':
                    close = STRING;
                    ToClose = true;
                    break;
                case '\'':
                    close = CHARACTER;
                    ToClose = true;
                    break;
                default:
                    ToClose = false;
                    break;
            }
        }

        public static string GetClosingChar()
        {
            ToClose = false;
            if (close < ClosingChar.Length)
                return ClosingChar[close];
            else
                return "";
        }
    }

}
