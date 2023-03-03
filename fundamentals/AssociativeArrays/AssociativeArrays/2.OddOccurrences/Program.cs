using System.Linq;

string[] strings = Console.ReadLine().Split();
Dictionary<string, int> dictionary = new Dictionary<string, int>();

foreach (var word in strings)
{
    string wordsToLower = word.ToLower();

    if (!dictionary.ContainsKey(wordsToLower))
    {
        dictionary.Add(wordsToLower, 0);

    }
    dictionary[wordsToLower]++;
}

//foreach (var word in dictionary)
//{
//    if (word.Value % 2 != 0)
//    {
//        Console.Write(word.Key + " ");
//    }
//}

var result = dictionary.Where(x => x.Value % 2 != 0).Select(x => x.Key).ToList();
Console.WriteLine(String.Join(" ", result));