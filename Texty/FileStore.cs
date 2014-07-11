using System;
using System.Collections.Generic;

namespace Texty
{
    class FileStore
    {
        private static Dictionary<string, FileContainer> Files = new Dictionary<string, FileContainer>();

        public static void AddFile(string name, string content)
        {
            Files[name] = new FileContainer(name, content);
        }

        public static void SetCurrent(string name)
        {
            foreach (var item in Files)
            {
                item.Value.Current = false;
            }
            Files[name].Current = true;
        }

        public static void RemoveFile(string name)
        {
            Files.Remove(name);
        }

        public static string GetContents(string name)
        {
            return Files[name].GetContents();
        }

    }
}
