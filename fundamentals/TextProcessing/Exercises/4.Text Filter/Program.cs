﻿string[] banned = Console.ReadLine().Split(", ");

string text = Console.ReadLine();

foreach (var word in banned)
{
    text = text.Replace(word, new string('*', word.Length));
}
Console.WriteLine(text);