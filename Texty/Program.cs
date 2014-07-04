using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Texty
{
    static class Program
    {

        public static String CurrentFile;
        public static bool IsSaved = false;
        public static bool IsNew = true;
        public static float zoom = 1.0f;
        public static String content = "";
        public static bool highlighted = false;
        public static int mode = TEXT;
        public static bool fromFindBox = false;
        public static bool readmode = true;

        public const String SETTINGS_FILE = "texty.settings";
        public const String HISTORY_FILE = "texty.history";
        public static Settings settings;

        public const int TEXT = 0;
        public const int DEVELOPER = 1;
        public const int RAW = 2;

        //internal static List<int> replaceIndexes;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }

    }
}
