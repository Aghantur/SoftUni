int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rotatos = int.Parse(Console.ReadLine());

for (int j = 0; j < rotatos; j++)
{

    int firstEle = input[0];

    for (int i = 0; i < input.Length - 1; i++)
    {

        input[i] = input[i + 1];
    }

    input[input.Length-1]=firstEle;
}


Console.WriteLine(string.Join(" ",input));