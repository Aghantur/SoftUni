using System.Text;


var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
var car2 = new Car("Audi", "A3", 110, "EB8787MN");

Console.WriteLine(car.ToString());
var parking = new Parking(5);
Console.WriteLine(parking.AddCar(car));
Console.WriteLine(parking.AddCar(car));

Console.WriteLine(parking.AddCar(car2));

Console.WriteLine(parking.GetCar("EB8787MN").ToString());


Console.WriteLine(parking.RemoveCar("EB8787MN"));


Console.WriteLine(parking.Count);

public class Car
{

    public Car(string make, string model, int hp, string regNumber)
    {
        Make = make;
        Model = model;
        Hp = hp;
        RegNumber = regNumber;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int Hp { get; set; }
    public string RegNumber { get; set; }

    public override string ToString()
    {

        StringBuilder sb = new();

        sb.AppendLine($"Make: {Make}");
        sb.AppendLine($"Model: {Model}");
        sb.AppendLine($"HorsePower: {Hp}");
        sb.AppendLine($"RegistrationNumber: {RegNumber}");

        return sb.ToString();

    }
}
public class Parking
{
    private Dictionary<string, Car> cars;
    private int Capacity;

    public Parking(int capacity)
    {
        this.Capacity = capacity;
        cars = new();
    }
    public int Count
    {
        get
        {
            return this.cars.Count;
        }
    }

    public string AddCar(Car car)
    {
        if (cars.ContainsKey(car.RegNumber))
        {
            return "Car with that registration number, already exists!";
        }

        if (Count == Capacity)
        {
            return "Parking is full!";
        }

        this.cars.Add(car.RegNumber, car);

        return $"Successfully added new car {car.Make} {car.RegNumber}";
    }
    public Car GetCar(string registrationNumber)
    {
        return cars[registrationNumber];
    }
    public string RemoveCar(string RegistrationNumber)
    {

        if (!cars.ContainsKey(RegistrationNumber))
        {
            return $"Car with that registration number, doesn't exist!";
        }
        cars.Remove(RegistrationNumber);
        return $"Successfully removed {RegistrationNumber}";
    }

    public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
    {
        foreach (var item in RegistrationNumbers)
        {
            RemoveCar(item);
        }
    }
}
