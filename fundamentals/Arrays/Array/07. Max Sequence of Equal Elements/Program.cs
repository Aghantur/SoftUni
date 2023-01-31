int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int longestSequenceStart = 0;
int longestSequenceLength = 0;

for (int i = 1; i < numbers.Length; i++)
{

    int currentSequenceStart = i - 1;
    int currentSequenceLength = 1;

    while (i < numbers.Length && numbers[i] == numbers[i - 1])
    {
        currentSequenceLength++;
        i++;
    }
    if (currentSequenceLength > longestSequenceLength)
    {
        longestSequenceLength = currentSequenceLength;
        longestSequenceStart = currentSequenceStart;
    }
}

for (int i = longestSequenceStart; i < longestSequenceStart + longestSequenceLength; i++)
{
    Console.Write($"{numbers[i]} ");
}