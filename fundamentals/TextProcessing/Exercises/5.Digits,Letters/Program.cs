﻿string text = Console.ReadLine();

//List<string> numbers = new List<string>();
//List<string> letters = new List<string>();
//List<string> symbols = new List<string>();

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] >= 'a' && text[i] <= 'z' || text[i] >= 'A' && text[i] <= 'Z')
//    {
//        letters.Add(text[i].ToString());
//    }
//    else if (text[i] >= '0' && text[i] <= '9')
//    {
//        numbers.Add(text[i].ToString());
//    }
//    else
//    {
//        symbols.Add(text[i].ToString());
//    }
//}



Console.WriteLine(String.Join("", text.Where(char.IsDigit)));
Console.WriteLine(String.Join("", text.Where(char.IsLetter)));
Console.WriteLine(String.Join("", text.Where(x => !char.IsLetter(x) && !char.IsDigit(x))));