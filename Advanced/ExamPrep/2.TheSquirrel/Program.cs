int n = int.Parse(Console.ReadLine());

string[] directions = Console.ReadLine().Split(", ");

char[,] field = new char[n, n];

int squirrelRow = 0;
int squirrelCol = 0;

for (int i = 0; i < field.GetLength(0); i++)
{
    string input = Console.ReadLine();

    for (int j = 0; j < field.GetLength(1); j++)
    {
        field[i, j] = input[j];

        if (field[i, j] == 's')
        {
            squirrelRow = i;

            squirrelCol = j;
        }
    }
}
int hazelnuts = 0;
foreach (var item in directions)
{
    if (item == "left")
    {
        if (!IsInside(field, squirrelRow, squirrelCol - 1))
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow, squirrelCol - 1] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow, squirrelCol - 1] == 'h')
        {
            hazelnuts++;
        }

        field[squirrelRow, squirrelCol - 1] = 's';
        field[squirrelRow, squirrelCol] = '*';
        squirrelCol--;
    }
    else if (item == "right")
    {

        if (!IsInside(field, squirrelRow, squirrelCol + 1))
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow, squirrelCol + 1] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow, squirrelCol + 1] == 'h')
        {
            hazelnuts++;
        }

        field[squirrelRow, squirrelCol + 1] = 's';
        field[squirrelRow, squirrelCol] = '*';
        squirrelCol++;
    }
    else if (item == "up")
    {

        if (!IsInside(field, squirrelRow - 1, squirrelCol))
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow - 1, squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow - 1, squirrelCol] == 'h')
        {
            hazelnuts++;
        }

        field[squirrelRow - 1, squirrelCol] = 's';
        field[squirrelRow, squirrelCol] = '*';
        squirrelRow--;
    }
    else if (item == "down")
    {

        if (!IsInside(field, squirrelRow + 1, squirrelCol))
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow + 1 , squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow + 1, squirrelCol] == 'h')
        {
            hazelnuts++;
        }

        field[squirrelRow + 1, squirrelCol] = 's';
        field[squirrelRow, squirrelCol] = '*';
        squirrelRow++;
    }
}

if(hazelnuts >= 3)
{
    Console.WriteLine("Good job! You have collected all hazelnuts!");
    Console.WriteLine($"Hazelnuts collected: {hazelnuts}");

}
else
{
    Console.WriteLine("There are more hazelnuts to collect.");
    Console.WriteLine($"Hazelnuts collected: {hazelnuts}");

}

bool IsInside(char[,] field, int row, int col)
{
    return row >= 0 && row < field.GetLength(0)
        && col >= 0 && col < field.GetLength(1);
}