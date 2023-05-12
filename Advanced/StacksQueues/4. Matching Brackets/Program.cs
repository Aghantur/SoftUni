
string input = Console.ReadLine();
Stack<int> stack = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        stack.Push(i);
    }
    else if (input[i] == ')')
    {
        int indexOpenBracket = stack.Pop();

        for (int j = indexOpenBracket; j <= i; j++)
        {
            Console.Write(input[j]);
        }
        Console.WriteLine();
    }
}