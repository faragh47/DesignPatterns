namespace Factory;
public class Car : Transport
{
    public override void Deliver()
    {
        Console.WriteLine("Delivering by Car");
    }
}
