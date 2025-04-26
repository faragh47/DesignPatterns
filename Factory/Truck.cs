namespace Factory;
public class Truck : Transport
{
    public override void Deliver()
    {
        Console.WriteLine("Delivering by Truck");
    }
}
