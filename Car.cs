namespace FactoryMethod;

public class Car : IDeliversFood
{
    public string LicensePlate { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public int Year { get; set; }
    public string  Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public async Task Deliver(int orderId)
    {
        await Task.FromResult($"Delivered Order: {orderId} via car");
    }
}