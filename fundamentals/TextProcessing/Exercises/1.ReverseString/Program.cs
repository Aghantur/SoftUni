
//while (true)
//{
//    string words = Console.ReadLine();
//    if (words == "end")
//    {
//        break;
//    }
//    string reversed = string.Empty;

//    for (int i = words.Length - 1; i >= 0; i--)
//    {
//        reversed += words[i];
//    }

//    Console.WriteLine($"{words} = {reversed}");
//}
string input = Console.ReadLine();
while (input != "end")
{
    char[] reversed = input.Reverse().ToArray();
    Console.WriteLine($"{input} = {string.Join("",reversed)}");

    input = Console.ReadLine(); 
}