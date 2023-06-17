int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

int playerRow = 0;
int playerCol = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{


    char[] colData = Console.ReadLine().ToCharArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = colData[col];

        if (matrix[row, col] == 'S')
        {
            playerRow = row;
            playerCol = col;
        }
    }
}

int minesTouched = 0;
int cruiser = 0;


string command;
while (minesTouched < 3 && cruiser < 3)
{
    command = Console.ReadLine();

    switch (command)
    {

        case "up":
            if (ValidateMove(playerRow - 1, playerCol, matrix))
            {


                matrix[playerRow, playerCol] = '-';
                if (matrix[playerRow - 1, playerCol] == '*')
                {
                    matrix[playerRow - 1, playerCol] = '-';

                    minesTouched++;
                }
                else if (matrix[playerRow - 1, playerCol] == 'C')
                {
                    matrix[playerRow - 1, playerCol] = '-';
                     
                    cruiser++;
                }

                matrix[playerRow - 1, playerCol] = 'S';
                playerRow--;
            }
            break;

        case "down":
            if (ValidateMove(playerRow + 1, playerCol, matrix))
            {

                matrix[playerRow, playerCol] = '-';
                if (matrix[playerRow + 1, playerCol] == '*')
                {
                    matrix[playerRow + 1, playerCol] = '-';

                    minesTouched++;
                }
                if (matrix[playerRow + 1, playerCol] == 'C')
                {
                    matrix[playerRow + 1, playerCol] = '-';

                    cruiser++;
                }
                matrix[playerRow + 1, playerCol] = 'S';

                playerRow++;
            }
            break;
        case "left":
            if (ValidateMove(playerRow, playerCol - 1, matrix))
            {
                matrix[playerRow, playerCol] = '-';
                if (matrix[playerRow, playerCol - 1] == '*')
                {
                    matrix[playerRow, playerCol - 1] = '-';

                    minesTouched++;
                }
                else if (matrix[playerRow, playerCol - 1] == 'C')
                {
                    matrix[playerRow, playerCol - 1] = '-';

                    cruiser++;
                }
                matrix[playerRow, playerCol - 1] = 'S';

                playerCol--;
            }
            break;
        case "right":
            if (ValidateMove(playerRow, playerCol + 1, matrix))
            {
                matrix[playerRow, playerCol] = '-';
                if (matrix[playerRow, playerCol + 1] == '*')
                {
                    matrix[playerRow, playerCol + 1] = '-';

                    minesTouched++;
                }
                else if (matrix[playerRow, playerCol + 1] == 'C')
                {
                    matrix[playerRow, playerCol + 1] = '-';

                    cruiser++;
                }
                matrix[playerRow , playerCol + 1] = 'S';

                playerCol++;
            }
            break;

        default:
            break;
    }

}

if (cruiser == 3)
{
    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");

    PrintMatrix(matrix);

}
else if (minesTouched == 3)
{
    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{playerRow}, {playerCol}]!");
    PrintMatrix(matrix);
}

void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(string.Join($"{0} ", matrix[row, col]));
        }
        Console.WriteLine();
    }
}

static bool ValidateMove(int row, int col, char[,] matrix)
{
    bool result = row >= 0
        && row < matrix.GetLength(0)
        && col >= 0 && col < matrix.GetLength(1);

    return result;
}