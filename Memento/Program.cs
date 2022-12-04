// See https://aka.ms/new-console-template for more information
using Memento;

Console.WriteLine("Hello, World!");

var editor = new Editor();
var history = new History();

editor.Content = "a";
history.push(editor.createState());

editor.Content = "b";
history.push(editor.createState());

editor.Content = "c";
editor.restore(history.pop());

Console.WriteLine(editor.Content);