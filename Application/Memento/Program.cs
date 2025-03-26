using Memento;

TextEditor textEditor = new TextEditor();

textEditor.AppendText("Hello");
textEditor.Save();
textEditor.AppendText(", I'm Steve!");
textEditor.MoveCursorTo(4);
textEditor.Save();
textEditor.GetStateForTest();

textEditor.WriteText("New text");
textEditor.MoveCursorTo(1);
textEditor.GetStateForTest();

textEditor.Undo();
textEditor.GetStateForTest();

textEditor.Undo();
textEditor.GetStateForTest();
