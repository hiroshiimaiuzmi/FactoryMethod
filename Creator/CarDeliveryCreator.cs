using FactoryMethod;

internal class CarDeliveryCreator : DeliveryCreator
{
    public IDeliversFood RegisterVehicle()
    {
        var car = new Car{
            Year = 2010,
            Color = "Black",
            Make = "Honda",
            Model = "Civic",
            LicensePlate = " 123"
        };
        Console.WriteLine("Registering a Car to deliver food!");
        return car;
    }
}