List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> bombDetails = Console.ReadLine().Split().Select(int.Parse).ToList();

int bomb = bombDetails[0];
int bombStrength = bombDetails[1];

while (numbers.Contains(bomb))
{


    int index = numbers.IndexOf(bomb);
    int start = index - bombStrength;

    if (start < 0)
    {
        start = 0;
    }
    int end = index + bombStrength;
    if (end > numbers.Count - 1)
    {
        end = numbers.Count - 1;
    }
    numbers.RemoveRange(start, end - start + 1);
   // Console.WriteLine(String.Join(" ", numbers));
}

int sum = numbers.Sum();
Console.WriteLine(sum);