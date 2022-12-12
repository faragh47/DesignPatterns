// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");


ImageStorage ImageStorage=new ImageStorage();


ImageStorage.Store("Image", new PngCompressor(),new BlackAndWhiteFilter() );


