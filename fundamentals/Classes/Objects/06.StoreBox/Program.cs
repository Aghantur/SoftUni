
List<Box> boxes = new List<Box>();

while (true)
{
    string info = Console.ReadLine();

    if (info == "end")
    {
        break;
    }
    string[] infoArr = info.Split();

    string serialNumber = infoArr[0];
    string itemName = infoArr[1];
    int itemQuantity = int.Parse(infoArr[2]);
    decimal itemPrice = decimal.Parse(infoArr[3]);

    Item item = new Item
    {
        Name = itemName,
        Price = itemPrice,
    };
    Box box = new Box
    {
        SerialNumber = serialNumber,
        Item = item,
        ItemQuantity = itemQuantity,
        PriceForBox = itemQuantity * itemPrice
    };
    boxes.Add(box);
}

foreach (var box in boxes.OrderByDescending(x=> x.PriceForBox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceForBox:f2}");
}

class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PriceForBox { get; set; }

}
class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}