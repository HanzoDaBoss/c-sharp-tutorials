string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderId in fraudulentOrderIDs)
{
    if (orderId.StartsWith("B"))
    {
        Console.WriteLine($"This order is {orderId}");
    }
}