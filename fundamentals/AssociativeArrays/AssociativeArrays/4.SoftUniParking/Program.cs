Dictionary<string, string> parking = new Dictionary<string, string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = commands[0];
    string username = commands[1];

    if (command == "register")
    {
        string plate = commands[2];

        if (parking.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {plate}");
        }
        else
        {
            parking[username] = plate;
            Console.WriteLine($"{username} registered {plate} successfully");
        }

    }
    else if (command == "unregister")
    {
        if (!parking.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {

            parking.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
    }


}

foreach (var car in parking)
{
    Console.WriteLine($"{car.Key} => {car.Value}");
}