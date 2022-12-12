// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Hello, World!");

var History = new BrowserHistory();

History.Init();

Iterator<string> iterator = History.CreateIterator();


while (iterator.hasNext())
{
    var url = iterator.current();
    Console.WriteLine(url);
    iterator.next();
}

Console.ReadLine();

