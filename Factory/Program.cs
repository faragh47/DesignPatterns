using Factory;

Console.WriteLine("Hello, World!");

var car = TransportFactor.CreateTransport("Car");
car.Deliver();