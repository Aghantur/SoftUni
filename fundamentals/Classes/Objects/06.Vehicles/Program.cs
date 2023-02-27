List<Car> cars = new List<Car>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "End")
    {
        break;
    }
    string[] inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string type = inputInfo[0];
    string model = inputInfo[1];
    string color = inputInfo[2];
    int hp = int.Parse(inputInfo[3]);

    Car car = new Car(type, model, color, hp);
    cars.Add(car);

}

while (true)
{
    string input = Console.ReadLine();
    if (input == "Close the Catalogue")
    {
        break;
    }
    Console.WriteLine(cars.Find(x => x.Model == input));
}

var onlyCars = cars.Where(x => x.Type == "car").ToList();
var onlyTrucks = cars.Where(x => x.Type == "truck").ToList();
double carsHp = 0;
double truckHp = 0;



if (onlyCars.Count > 0 && onlyTrucks.Count <= 0)
{

    carsHp = onlyCars.Average(x => x.hp);
   // truckHp = onlyTrucks.Average(x => x.hp);

    Console.WriteLine($"Cars have average horsepower of: {carsHp:f2}.");
    Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");

}
else if (onlyTrucks.Count > 0 && onlyCars.Count <= 0)
{

    //carsHp = onlyCars.Average(x => x.hp);
    truckHp = onlyTrucks.Average(x => x.hp);

    Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
    Console.WriteLine($"Trucks have average horsepower of: {truckHp:f2}.");

}
else 
{
    carsHp = onlyCars.Average(x => x.hp);
    truckHp = onlyTrucks.Average(x => x.hp);
    Console.WriteLine($"Cars have average horsepower of: {carsHp:f2}.");
    Console.WriteLine($"Trucks have average horsepower of: {truckHp:f2}.");
}


public class Car
{
    public Car(string type, string model, string color, int hp)
    {
        Type = type;
        Model = model;
        this.color = color;
        this.hp = hp;
    }

    public string Type { get; set; }
    public string Model { get; set; }
    public string color { get; set; }
    public int hp { get; set; }
    public override string ToString()
    {
        return $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
               $"Model: {this.Model}{Environment.NewLine}" +
               $"Color: {this.color}{Environment.NewLine}" +
               $"Horsepower: {this.hp}";
    }

}
