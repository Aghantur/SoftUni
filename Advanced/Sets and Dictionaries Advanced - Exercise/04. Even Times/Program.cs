﻿Dictionary<int, int> numbersCounts = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!numbersCounts.ContainsKey(number))
    {
        numbersCounts.Add(number, 0);
    }

    numbersCounts[number]++;
}

Console.WriteLine(numbersCounts.Single(n => n.Value % 2 == 0).Key);