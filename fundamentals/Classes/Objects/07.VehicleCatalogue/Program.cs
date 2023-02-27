
Catalog catalog = new Catalog();

while (true)
{
    string input = Console.ReadLine();

    if (input == "end")
    {
        break;
    }
    string[] inputInfo = input.Split('/');

    string type = inputInfo[0];
    string brand = inputInfo[1];
    string model = inputInfo[2];
    int hp = int.Parse(inputInfo[3]);

    if (type == "Car")
    {
        Car car = new Car
        {
            Brand = brand,
            Model = model,
            hp = hp

        };
        catalog.Cars.Add(car);
    }
    else
    {
        Truck truck = new Truck
        {
            Brand = brand,
            Model = model,
            weight = hp
        };
        catalog.Trucks.Add(truck);
    }

}
Console.WriteLine("Cars:");
foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
{
    Console.WriteLine($"{car.Brand}: {car.Model} - {car.hp}hp");
}

Console.WriteLine("Trucks:");
foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
{

    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.weight}kg");
}


class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int weight { get; set; }
}
class Car
{

    public string Brand { get; set; }
    public string Model { get; set; }
    public int hp { get; set; }
}
class Catalog
{
    public Catalog()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }

    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }

    
}