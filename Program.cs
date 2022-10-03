Console.WriteLine("Welcome to the Food Delivery Service!");
Console.WriteLine("-------------------------------------");
Console.WriteLine("Please enter a delivery type.");

var deliveryType = Console.ReadLine();

if (string.IsNullOrWhiteSpace(deliveryType))
{
    Console.WriteLine("Error reading delivery type.");
    throw new InvalidOperationException();
}

try
{
    var deliveryCreator = BuildDeliveryCreator(deliveryType);
    deliveryCreator.RegisterVehicle();
}
catch (Exception ex)
{
    Console.WriteLine($"Error creating delivery : {ex.Message}");
    throw;
}

static DeliveryCreator BuildDeliveryCreator(string deliveryType)
{
    List<string> validDeliveryOptions = new() { "bicycle", "car" };

    if (!validDeliveryOptions.Contains(deliveryType)){
        Console.WriteLine("Please enter a type of delivery [bicycle, car]");
        throw new InvalidOperationException();
    }

    return deliveryType switch {
        "bicycle" => new BicycleDeliveryCreator(),
        "car" => new CarDeliveryCreator(),
        _ => throw new InvalidOperationException("Cannot set up delivery without valid Delivery Type."),
    };
}