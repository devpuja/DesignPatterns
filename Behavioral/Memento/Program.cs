using Memento;

var editor = new TextEditor();
var history = new History();

editor.Write("Hello, ");
history.Save(editor.Save());

editor.Write("world!");
Console.WriteLine(editor.Text);


// Get Previous state
var previousState = history.Undo();
editor.Restore(previousState);
Console.WriteLine(editor.Text);