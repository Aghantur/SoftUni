using System.Security.Authentication;

int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

while (true)
{
    string input = Console.ReadLine();

    if (input == "end")
    {
        break;
    }
    if (input.StartsWith("exchange"))
    {
        int index = int.Parse(input.Split().Last());

        if (index < 0 || index >= arr.Length)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        arr = Exchange(arr, index);

    }
    else if (input.StartsWith("max"))
    {
        var condition = input.Split().Last();
        MaxIndexForCondition(arr, condition == "even");
    }
    else if (input.StartsWith("min"))
    {

        var condition = input.Split().Last();
        MinIndexForCondition(arr, condition == "even");
    }
    else if (input.StartsWith("first"))
    {
        string[] conditions = input.Split();
        int count = int.Parse(conditions[1]);
        FirstElementsForCondition(arr, count, conditions.Last() == "even");


    }
    else if (input.StartsWith("last"))
    {

        string[] conditions = input.Split();
        int count = int.Parse(conditions[1]);
        LastElementsForCondition(arr, count, conditions.Last() == "even");

    }


}


Console.WriteLine("[{0}]", string.Join(", ", arr));


int[] Exchange(int[] arr, int index)
{

    return arr.Skip(index + 1).Take(arr.Length).Concat(arr.Take(index + 1)).ToArray();

}


void MaxIndexForCondition(int[] arr, bool isEven)
{

    if (!arr.Any(number => isEven == (number % 2 == 0)))
    {
        Console.WriteLine("No matches");
    }
    else
    {
        int max = arr.Where(number => isEven == (number % 2 == 0)).Max();
        Console.WriteLine(Array.LastIndexOf(arr, max));
    }

}

void MinIndexForCondition(int[] arr, bool isEven)
{
    if (!arr.Any(number => isEven == (number % 2 == 0)))
    {
        Console.WriteLine("No matches");
    }
    else
    {
        int min = arr.Where(number => isEven == (number % 2 == 0)).Min();
        Console.WriteLine(Array.LastIndexOf(arr, min));
    }
}


void FirstElementsForCondition(int[] arr, int count, bool isEven)
{

    if (count > arr.Length)
    {
        Console.WriteLine("Invalid count");
    }
    else
    {
        int[] result = arr.Where(number => isEven == (number % 2 == 0)).Take(count).ToArray();
        Console.WriteLine("[{0}]", string.Join(", ", result));
    }

}


void LastElementsForCondition(int[] arr, int count, bool isEven)
{
    if (count > arr.Length)
    {
        Console.WriteLine("Invalid count");
    }
    else
    {
        int[] result = arr.Where(number => isEven == (number % 2 == 0)).TakeLast(count).ToArray();
        Console.WriteLine("[{0}]", string.Join(", ", result));
    }
}