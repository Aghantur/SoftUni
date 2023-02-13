int n = int.Parse(Console.ReadLine());

List<string> prod = new List<string>();

for (int i = 0; i < n; i++)
{
    string currProduct = Console.ReadLine();
    prod.Add(currProduct);
}
prod.Sort();

for (int i = 0; i < prod.Count; i++)
{
    Console.WriteLine($"{i + 1}.{prod[i]}");
}