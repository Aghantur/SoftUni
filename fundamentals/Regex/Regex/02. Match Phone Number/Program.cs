﻿using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
Regex regex = new Regex(pattern);

MatchCollection result = regex.Matches(text);


Console.WriteLine(string.Join(", ", result));
