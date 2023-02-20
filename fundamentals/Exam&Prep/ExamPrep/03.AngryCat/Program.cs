int[] number = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int entry = int.Parse(Console.ReadLine());
int arrEntry = number[entry];
string command = Console.ReadLine();

int sumLeft = 0;
int sumRight = 0;

for (int i = 0; i < entry; i++)
{
    if (command == "cheap" && number[i] < arrEntry)
    {

        sumLeft += number[i];
    }
    else if (command == "expensive" && number[i] >= arrEntry)
    {
        sumLeft += number[i];
    }
}
for (int i = entry + 1; i <= number.Length - 1; i++)
{
    if (command == "cheap" && number[i] < arrEntry)
    {

        sumRight += number[i];
    }
    else if (command == "expensive" && number[i] >= arrEntry)
    {
        sumRight += number[i];
    }
}

if (sumLeft >= sumRight)
{
    Console.WriteLine($"Left - {sumLeft}");
}
else
{
    Console.WriteLine($"Right - {sumRight}");
}