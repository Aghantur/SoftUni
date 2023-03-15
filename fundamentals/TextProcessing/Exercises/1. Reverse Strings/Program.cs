string word = Console.ReadLine();
string words = Console.ReadLine();


while (words.Contains(word))
{
    int index = words.IndexOf(word);
   words = words.Remove(index,word.Length);
}

Console.WriteLine(words);