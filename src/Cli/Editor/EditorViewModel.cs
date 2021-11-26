namespace NoteIt.Cli.Editor
{
    //Caretaker
    public class EditorViewModel
    {
        public Stack<RestorePoint> RestorePoints { get; set; } = new();
        private TextEditor textEditor = new(fontSize: 12, fontFamily: "Ubuntu mono");

        private void CreateRestorePoint()
        {
            RestorePoints.Push(textEditor.CreateRestorePoint());

        }
        public string Content
        {
            get => textEditor.Content;
            set
            {
                CreateRestorePoint();
                textEditor.Content = value;
            }
        }

        public string FontFamily
        {
            get => textEditor.FontFamily;
            set
            {
                CreateRestorePoint();
                textEditor.FontFamily = value;
            }
        }

        public int FontSize
        {
            get => textEditor.FontSize; set
            {
                CreateRestorePoint();
                textEditor.FontSize = value;
            }
        }
        public void Undo()
        {
            //Check if the is a restore point then restore to it.
            if (RestorePoints.Count > 1)
            {
                textEditor.Restore(RestorePoints.Pop());
            }
        }
    }
}