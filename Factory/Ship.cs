namespace Factory;
public class Ship : Transport
{
    public override void Deliver()
    {
        Console.WriteLine("Delivering by Ship");
    }
}
