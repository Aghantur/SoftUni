string[] words = Console.ReadLine().Split();

for (int i = 0; i < words.Length - 1; i++)
{
    Random rand = new Random();
    int randomIndex = rand.Next(0, words.Length);
    string currWord = words[i];
    string wordToSwap = words[randomIndex];

    words[i] = wordToSwap;
    words[randomIndex] = currWord;
}
Console.WriteLine(String.Join(Environment.NewLine,words));