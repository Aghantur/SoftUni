Dictionary<string, double[]> products = new Dictionary<string, double[]>();


while (true)
{
    string input = Console.ReadLine();

    if (input == "buy")
    {
        break;
    }

    string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string product = inputArr[0];
    double price = double.Parse(inputArr[1]);
    double quantity = double.Parse(inputArr[2]);

    if (!products.ContainsKey(product))
    {
        products[product] = new double[2];
    }

    products[product][0] = price;
    products[product][1] += quantity;
}


foreach (var item in products)
{

    double totalPrice = item.Value[0] * item.Value[1];
    Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
}