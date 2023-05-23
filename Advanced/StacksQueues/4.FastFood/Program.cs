int quantity = int.Parse(Console.ReadLine());


Queue<int> orders = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Console.WriteLine(orders.Max());
while (orders.Any())
{
    int currOrder = orders.Peek();
    quantity -= currOrder;

    if (quantity < 0 )
    {
        break;
    }
    orders.Dequeue();
}

if (!orders.Any())
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
}