// See https://aka.ms/new-console-template for more information
using State;

Console.WriteLine("Hello, World!");


var canvas = new Canvas();

canvas.mouseUp(new BrushTool());

canvas.mouseDown(new BrushTool());

canvas.mouseUp(new SelectionTool());

canvas.mouseDown(new SelectionTool());


