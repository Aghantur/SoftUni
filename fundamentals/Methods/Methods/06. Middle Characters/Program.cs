string input = Console.ReadLine();


Console.WriteLine(PrintMidChar(input));

static string PrintMidChar(string input)
{
    string result = "";
    if (input.Length % 2 != 0)
    {
         result= input[input.Length / 2].ToString();
    }
    else
    {

        result = input[input.Length / 2 - 1].ToString() + input[input.Length/2 ].ToString();
    }

    return result;
}