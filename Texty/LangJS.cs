using System;
using System.Collections.Generic;
using System.Drawing;

namespace Texty
{
    class LangJS
    {
        public static String[] keywords = { "break", "case", "continue", "catch", "do", "default",
                                            "else", "for", "function", "if", "in", "new", "prototype",
                                            "return", "switch", "this", "try", "typeof", "var", 
                                            "while", "with" };

        public static List<Triplet> GetIndexesWithColor(String text,
                                                        Color keyword_color,
                                                        Color comment_color,
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
                else if (c == '\'' && prev != '"')
                {
                    int length = 0;
                    start = i;
                    while (i < text.Length)
                    {
                        ++length;
                        ++i;
                        if (text[i] == '\'' && text[i-1] != '\\')
                            break;
                    }
                    triplet.start = start;
                    triplet.end = length;
                    triplet.color = string_color;
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
