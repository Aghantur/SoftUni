string filePath = Console.ReadLine();

//Console.WriteLine($"File name: {Path.GetFileNameWithoutExtension(filePath)}");
//Console.WriteLine($"File extension: {Path.GetExtension(filePath).Trim('.')}");

string[] file = filePath.Substring(filePath.LastIndexOf(@"\") + 1).Split('.');

Console.WriteLine($"File name: {file.First()}");
Console.WriteLine($"File extension: {file.Last()}");