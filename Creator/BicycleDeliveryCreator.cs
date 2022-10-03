using FactoryMethod;

public class BicycleDeliveryCreator : DeliveryCreator
{
    public IDeliversFood RegisterVehicle()
    {
        var bicycle = new Bicycle{
            Color = "Blue",
            Style = "Road",
            Make = "Trek",
            Model = "Foo",
        };
        Console.WriteLine("Registering a Bicycle to deliver food!");
        return bicycle;
    }
}