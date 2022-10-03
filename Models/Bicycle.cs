namespace FactoryMethod;

public class Bicycle : IDeliversFood
{
    public string Color { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Style { get; set; } = string.Empty;
    public async Task Deliver(int orderId)
    {
        await Task.FromResult($"Delivered Order: {orderId} via bicycle");
    }
}