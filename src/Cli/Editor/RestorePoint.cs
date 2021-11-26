using NoteIt.Cli.Editor;

namespace NoteIt.Cli
{
    /// <summary>
    /// RestorePoint is a memento class for out TextEditor
    /// </summary>
    public class RestorePoint
    {
        public TextEditor State { get; }
        public RestorePoint(TextEditor editorState)
        {
            State = editorState;
        }
    }
}