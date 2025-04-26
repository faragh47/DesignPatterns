namespace Factory;
public class Bike : Transport
{
    public override void Deliver()
    {
        Console.WriteLine("Delivering by Bike");
    }
}
