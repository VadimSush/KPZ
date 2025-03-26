namespace Memento
{
    public class TextEditor
    {
        private readonly Stack<TextDocument> _changeHistory = new Stack<TextDocument>();

        private string text = "";

        private int cursorSeek;

        public void AppendText(string newText)
        {
            text += newText;
        }

        public void WriteText(string newText)
        {
            text = newText;
        }

        public void MoveCursorTo(int newSeekPosition)
        {
            cursorSeek = newSeekPosition;
        }

        public void GetStateForTest()
        {
            Console.WriteLine($"Text: {text}, cursorSeek: {cursorSeek}");
        }

        public void Undo()
        {
            if (_changeHistory.Count > 0)
            {
                TextDocument textDocument = _changeHistory.Pop();
                textDocument.Restore();
            }
        }

        public void Save()
        {
            TextDocument textDocument = new TextDocument(this);
            _changeHistory.Push(textDocument);
        }

        public class TextDocument
        {
            private string text;

            private int cursorSeek;

            private readonly TextEditor _textEditor;

            public TextDocument(TextEditor textEditor)
            {
                _textEditor = textEditor;
                text = _textEditor.text;
                cursorSeek = _textEditor.cursorSeek;
            }

            public void Restore()
            {
                _textEditor.text = text;
                _textEditor.cursorSeek = cursorSeek;
            }
        }
    }
}
