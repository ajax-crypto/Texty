using System;
using System.Collections.Generic;
using System.Drawing;

namespace Texty
{
    class LangCSharp
    {
        public static String[] keywords = { "abstract", "as", "base", "bool", "break", "byte", "case", "continue", "char", "class", "catch",
                                            "const", "checked", "decimal", "delegate", "do", "default", "double", "else", "enum", "event", "explicit", 
                                            "extern", "false", "fixed", "finally", "float", "for", "foreach", "goto", "in", "implicit", "int", 
                                            "if", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object",
                                            "operator", "out", "override", "params", "private", "protected", "public", "package", "partial", "return", "readonly",
                                            "ref", "sbyte", "sealed", "static", "stackalloc", "switch", "short", "struct", "sizeof", "string",
                                            "try", "throw", "typeof", "this", "true", "union", "uint", "ulong", "unchecked", "ushort", "using", 
                                            "virtual", "volatile", "void", "while", "yield" };

        public static List<Triplet> GetIndexesWithColor(String text,
                                                        Color keyword_color,
                                                        Color comment_color,
                                                        Color region_color,
                                                        Color string_color)
        {
            List<Triplet> list = new List<Triplet>();
            int start = 0;
            char prev = '\0';
            String keyword = "";
            Triplet triplet = new Triplet();
            for (int i = 0; i < text.Length; ++i)
            {
                char c = text[i];
                if (char.IsLetter(c) || char.IsNumber(c))
                {
                    if (!char.IsLetter(prev) && !char.IsNumber(prev))
                        start = i;
                    keyword += c;
                }
                else if (c == '#')
                {
                    int length = 0;
                    start = i;
                    while (i < text.Length)
                    {
                        ++length;
                        ++i;
                        if (text[i] == '\n' || (text[i] == '\n' && text[i - 1] == '\r'))
                            break;
                    }
                    triplet.start = start;
                    triplet.end = length;
                    triplet.color = region_color;
                    list.Add(triplet);
                }
                else if (c == '"' && prev != '\'')
                {
                    int length = 0;
                    start = i;
                    while (i < text.Length)
                    {
                        ++length;
                        ++i;
                        if (text[i] == '"' && text[i - 1] != '\\')
                            break;
                    }
                    triplet.start = start;
                    triplet.end = length + 1;
                    triplet.color = string_color;
                    list.Add(triplet);
                }
                else if (c == '/')
                {
                    start = i;
                    ++i;
                    int length = 0;
                    if (text[i] == '*')
                    {
                        ++i;
                        length = 2;
                        while (i < text.Length)
                        {
                            if (text[i] == '/' && text[i - 1] == '*')
                                break;
                            ++i;
                            ++length;
                        }
                        triplet.color = comment_color;
                    }
                    else if (text[i] == '/')
                    {
                        while (i < text.Length)
                        {
                            ++length;
                            ++i;
                            if (text[i] == '\n' || (text[i] == '\n' && text[i - 1] == '\r'))
                                break;
                        }
                        triplet.color = comment_color;
                    }
                    triplet.start = start;
                    triplet.end = length + 1;
                    list.Add(triplet);
                }
                else
                {
                    foreach (String word in keywords)
                    {
                        if (keyword.Equals(word))
                        {
                            triplet.start = start;
                            triplet.end = keyword.Length;
                            triplet.color = keyword_color;
                            list.Add(triplet);
                        }
                    }
                    keyword = "";
                }
                prev = c;
            }
            return list;
        }
    
    
    }
}
