using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Texty
{
    class FileHandler
    {
        static readonly string[] word_file = { ".doc", ".docx" };
        static readonly string[] rfile = { ".pdf" };
        static readonly string[] rtf = { ".rtf" };
        static readonly string[] code_file = { ".c", ".h", ".cpp", ".js", ".java", ".cs", ".py" };

        public const int WORD = 0;
        public const int PDF = 1;
        public const int CODE = 2;
        public const int PTEXT = 3;
        public const int RTEXT = 4;

        public static int Type = PTEXT;

        public static int ReadFile(string name, 
                                   ref System.Windows.Forms.RichTextBox LoadArea)
        {
            string ext = Path.GetExtension(name);
            Type = PTEXT;
            foreach (var item in word_file)
                if (item.Equals(ext))
                {
                    Type = WORD;
                    ReadFromMSWordFile(name, ref LoadArea);
                    return Type;
                }

            foreach (var item in rfile)
                if (item.Equals(ext))
                {
                    Type = PDF;
                    ReadFromPDFFile(name, ref LoadArea);
                    return Type;
                }

            foreach (var item in rtf)
                if (item.Equals(ext))
                {
                    Type = RTEXT;
                    ReadFromRTFFile(name, ref LoadArea);
                    return Type;
                }

            foreach (var item in code_file)
                if (item.Equals(ext))
                {
                    Type = CODE;
                }

            ReadFromFile(name, ref LoadArea);            
            return Type;
        }

        public static List<Triplet> GetHighlightingInfo(string name, string content)
        {
            string ext = Path.GetExtension(name);
            List<Triplet> list = new List<Triplet>();
            if (ext.Equals(".c"))
            {
                list = LangC.GetIndexesWithColor(content,
                    Color.Blue, Color.Gray, Color.DarkGreen, Color.Maroon);
            }
            else if (ext.Equals(".cpp"))
            {
                list = LangCPP.GetIndexesWithColor(content,
                    Color.Blue, Color.Gray, Color.DarkGreen, Color.Maroon);

            }
            else if (ext.Equals(".java"))
            {
                list = LangJava.GetIndexesWithColor(content,
                    Color.Blue, Color.Gray, Color.Maroon);

            }
            else if (ext.Equals(".cs"))
            {
                list = LangCSharp.GetIndexesWithColor(content,
                    Color.Blue, Color.Gray, Color.DarkGreen, Color.Maroon);
            }
            else if (ext.Equals(".js"))
            {
                list = LangJS.GetIndexesWithColor(content,
                    Color.Blue, Color.Gray, Color.Maroon);
            }
            return list;
        }

        private static void ReadFromFile(string name, ref System.Windows.Forms.RichTextBox LoadArea)
        {
            LoadArea.Text = File.ReadAllText(name);
        }

        private static void ReadFromRTFFile(string name, ref System.Windows.Forms.RichTextBox LoadArea)
        {
            LoadArea.LoadFile(name);
        }

        private static void ReadFromPDFFile(string name, ref System.Windows.Forms.RichTextBox LoadArea)
        {
            iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(name);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            LoadArea.Text = text;
        }

        private static void ReadFromMSWordFile(string name, ref System.Windows.Forms.RichTextBox LoadArea)
        {
            Spire.Doc.Document doc = new Spire.Doc.Document();
            doc.LoadFromFile(name);
            doc.SaveToFile("temp.rtf", Spire.Doc.FileFormat.Rtf);
            LoadArea.LoadFile("temp.rtf");
            File.Delete("temp.rtf");
        }


    }
}
