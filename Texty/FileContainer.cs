namespace Texty
{
    class FileContainer
    {
        private string Path;
        private string Contents;
        public bool Current;

        public FileContainer(string path, string rtf)
        {
            this.Path = path;
            this.Contents = rtf;
            this.Current = false;
        }

        public string GetContents() { return Contents; }
        public string GetPath() { return Path; }
        public string GetName() { return System.IO.Path.GetFileName(Path); }
        public override string ToString() { return GetName(); }
    }
}
