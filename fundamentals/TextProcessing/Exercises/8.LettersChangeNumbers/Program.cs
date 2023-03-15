string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

double sum = 0;

foreach (var item in input)
{
    double result = 0;

    char first = item.First();
    char last = item.Last();

    double firstOperand = double.Parse(item.Substring(1, item.Length - 2));
    double secondOperand = GetLetterPosition(first);
    double thirdOperand = GetLetterPosition(last);

    if (char.IsUpper(first))
    {
        result = firstOperand / secondOperand;
    }
    else
    {
        result = firstOperand * secondOperand;
    }

    if (char.IsUpper(last))
    {
        result -= thirdOperand;
    }
    else
    {
        result += thirdOperand;
    }

    sum += result;

}

Console.WriteLine($"{sum:f2}");


static int GetLetterPosition(char c)
{
    return c.ToString().ToLower().First() - 96;
}