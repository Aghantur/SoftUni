string input = Console.ReadLine();

Console.WriteLine( Vowels(input) ); 
int Vowels(string input)
{
    int count = 0;

    foreach (var character in input)
    {
        if (isVowel(character))
        {
            count++;
        }
    }
    return count;

}

bool isVowel(char character)
{
    return "aeiouyAEIOUY".IndexOf(character) >= 0;


}
