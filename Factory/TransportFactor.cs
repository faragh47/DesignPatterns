namespace Factory;
public static class TransportFactor
{
    public static Transport CreateTransport(string type) => type.ToLower() switch
    {
        "bike" => new Bike(),
        "car" => new Car(),
        "truck" => new Truck(),
        "ship" => new Ship(),
        _ => throw new ArgumentException("Invalid transportation type")
    };
}
