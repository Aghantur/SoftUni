string[] input = Console.ReadLine().Split();

Stack<string> expressions = new Stack<string>(input.Reverse());

int result = int.Parse(expressions.Pop()); 


while (expressions.Any())
{

    string sign = expressions.Pop();
    int number = int.Parse(expressions.Pop());

    if (sign == "+")
    {
        result += number;
    }
    else if (sign == "-")
    {
        result -= number;
    }
}

Console.WriteLine(result);