namespace NoteIt.Cli.Editor
{

    public struct TextEditor
    {
        public TextEditor(int fontSize, string fontFamily)
        {
            FontSize = fontSize;
            FontFamily = fontFamily;
        }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int FontSize { get; set; } = 12;
        public string FontFamily { get; set; } = string.Empty;

        public void Restore(RestorePoint restorePoint)
        {
            this = restorePoint.State;
        }
        public RestorePoint CreateRestorePoint()
        {
            return new RestorePoint(this);
        }
    }
}