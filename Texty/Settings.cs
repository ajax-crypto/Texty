using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Texty
{
    [Serializable()]
    class Settings : ISerializable
    {

        public struct RGBColor
        {
            public int R, G, B;
        }
        
        internal string FontFamily { get; set; }
        internal bool WordWrap { get; set; }
        internal RGBColor ForeColor;
        internal RGBColor BackColor;
        internal float FontSize { get; set; }
        internal int Alignment { get; set; }

        public const int LEFTALIGN = 0;
        public const int CENTERALIGN = 1;
        public const int RIGHTALIGN = 2;

        public Settings() 
        {
        }

        public Settings(SerializationInfo info, StreamingContext ctxt)
        {
            FontFamily = (string)info.GetValue("FontFamily", typeof(string));
            FontSize = (float)info.GetValue("FontSize", typeof(float));
            WordWrap = (bool)info.GetValue("WordWrap", typeof(bool));
            ForeColor.R = (int)info.GetValue("FR", typeof(int));
            BackColor.R = (int)info.GetValue("BR", typeof(int));
            ForeColor.G = (int)info.GetValue("FG", typeof(int));
            BackColor.G = (int)info.GetValue("BG", typeof(int));
            ForeColor.B = (int)info.GetValue("FB", typeof(int));
            BackColor.B = (int)info.GetValue("BB", typeof(int));
            Alignment = (int)info.GetValue("Align", typeof(int));
        }

        public static Settings GetSettingsObject()
        {
            Stream file = null;
            Settings temp = null;
            try
            {
                file = File.Open(Program.SETTINGS_FILE, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                temp = (Settings)bf.Deserialize(file);
                return temp;
            }
            catch (FileNotFoundException exp)
            {
                temp = new Settings();
                temp.FontFamily = "Courier New";
                temp.FontSize = 9f;
                temp.WordWrap = false;
                temp.ForeColor.R = 0;
                temp.ForeColor.G = 0;
                temp.ForeColor.B = 0;
                temp.BackColor.R = 255;
                temp.BackColor.G = 255;
                temp.BackColor.B = 255;
                temp.Alignment = LEFTALIGN;
            }
            return temp;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("FontFamily", FontFamily);
            info.AddValue("FontSize", FontSize);
            info.AddValue("WordWrap", WordWrap);
            info.AddValue("FR", ForeColor.R);
            info.AddValue("BR", BackColor.R);
            info.AddValue("FG", ForeColor.G);
            info.AddValue("BG", BackColor.G);
            info.AddValue("FB", ForeColor.B);
            info.AddValue("BB", BackColor.B);
            info.AddValue("Align", Alignment);
        }

        public void SaveToFile()
        {
            if(File.Exists(Program.SETTINGS_FILE))
                File.WriteAllText(Program.SETTINGS_FILE, "");
            try
            {
                Stream file = File.Open(Program.SETTINGS_FILE, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, this);
                file.Close();
            }
            catch (Exception exp)
            {
            }
        }

        public void AssignForeColor(int r, int g, int b)
        {
            this.ForeColor.R = r;
            this.ForeColor.G = g;
            this.ForeColor.B = b;
        }

        public void AssignBackColor(int r, int g, int b)
        {
            this.BackColor.R = r;
            this.BackColor.G = g;
            this.BackColor.B = b;
        }

    }
}
