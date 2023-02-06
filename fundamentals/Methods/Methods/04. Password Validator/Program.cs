string password = Console.ReadLine();

bool isValid = true;


if (!IsLengthValid(password))
{
    isValid = false;
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!OnlyContainsDigits(password))
{
    isValid = false;
    Console.WriteLine("Password must consist only of letters and digits");

}
if (!ContainsAtleast2Digits(password))
{
    isValid = false;
    Console.WriteLine("Password must have at least 2 digits");
}
if (isValid)
{

    Console.WriteLine("Password is valid");
}

bool ContainsAtleast2Digits(string password)
{

    return password.Count(char.IsDigit) >= 2;
}

bool OnlyContainsDigits(string password)
{

    return password.All(char.IsLetterOrDigit);
}

bool IsLengthValid(string password)
{
    return password.Length is >= 6 and <= 10;

}

