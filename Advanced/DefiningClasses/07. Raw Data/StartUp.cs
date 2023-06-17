List<Car> cars = new List<Car>();
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count - 1; i++)
{
    string[] carProps = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Car car = new(
                carProps[0],
                int.Parse(carProps[1]),
                int.Parse(carProps[2]),
                int.Parse(carProps[3]),
                carProps[4],
                double.Parse(carProps[5]),
                int.Parse(carProps[6]),
                double.Parse(carProps[7]),
                int.Parse(carProps[8]),
                double.Parse(carProps[9]),
                int.Parse(carProps[10]),
                double.Parse(carProps[11]),
                int.Parse(carProps[12])
                );


    cars.Add(car);
}

string command = Console.ReadLine();

string[] filter;
if (command == "fragile")
{
    filter = cars.Where(x => x.Cargo.Type == "fragile" && x.Tyres.Any(x => x.Pressure < 1)).Select(x => x.Model).ToArray();
}
else
{
    filter = cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250).Select(x => x.Model).ToArray();

}
Console.WriteLine(string.Join(Environment.NewLine, filter));

public class Tyre
{

    public Tyre(double pressure, int age)
    {
        Pressure = pressure;
        Age = age;
    }

    public double Pressure { get; set; }
    public int Age { get; set; }
}
public class Engine
{
    public Engine(int speed, int power)
    {
        Speed = speed;
        Power = power;
    }

    public int Speed { get; set; }
    public int Power { get; set; }
}
public class Cargo
{
    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type;
    }
    public int Weight { get; set; }

    public string Type { get; set; }

}
public class Car
{

    public Car(
        string model,
        int speed,
        int power,
        int weight,
        string type,
        double tyre1Pressure,
        int tyre1Age,
        double tyre2Pressure,
        int tyre2Age,
        double tyre3Pressure,
        int tyre3Age,
        double tyre4Pressure,
        int tyre4Age)
    {
        Model = model;
        Engine = new(speed, power);
        Cargo = new(weight, type);
        Tyres = new Tyre[4];
        Tyres[0] = new(tyre1Pressure, tyre1Age);
        Tyres[1] = new(tyre2Pressure, tyre2Age);
        Tyres[2] = new(tyre3Pressure, tyre3Age);
        Tyres[3] = new(tyre4Pressure, tyre4Age);
    }

    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public Tyre[] Tyres { get; set; }
}