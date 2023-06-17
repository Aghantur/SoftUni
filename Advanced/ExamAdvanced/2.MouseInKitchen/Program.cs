int[] dimensions = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = dimensions[0];
int cols = dimensions[1];
char[,] matrix = new char[rows, cols];

int playerRow = 0;
int playerCol = 0;

for (int row = 0; row < rows; row++)
{
    char[] colData = Console.ReadLine().ToCharArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = colData[col];

        if (matrix[row, col] == 'M')
        {
            playerRow = row;
            playerCol = col;
        }
    }
}

string command;

while ((command = Console.ReadLine()) != "danger")
{
    switch (command)
    {

        case "up":
            if (ValidateMove(playerRow - 1, playerCol, matrix))
            {
                matrix[playerRow, playerCol] = '*';

                if (Cheese(matrix))
                {

                    if (matrix[playerRow - 1, playerCol] == 'C')
                    {
                        matrix[playerRow - 1, playerCol] = 'M';

                    }
                    else if (matrix[playerRow - 1, playerCol] == 'T')
                    {

                        Console.WriteLine("Mouse is trapped!");
                        matrix[playerRow - 1, playerCol] = 'M';
                        PrintMatrix(matrix);
                        return;
                    }
                    else if (matrix[playerRow - 1, playerCol] == '*')
                    {
                        matrix[playerRow, playerCol - 1] = 'M';
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    matrix[playerRow, playerCol] = '*';

                    matrix[playerRow - 1, playerCol] = 'M';

                    PrintMatrix(matrix);
                    return;
                }


                matrix[playerRow - 1, playerCol] = 'M';

                playerRow--;
            }
            else
            {
                Console.WriteLine("No more cheese for tonight!");
                matrix[playerRow, playerCol] = 'M';

                PrintMatrix(matrix);
                return;
            }

            break;

        case "down":
            if (ValidateMove(playerRow + 1, playerCol, matrix))
            {
                matrix[playerRow, playerCol] = '*';

                if (Cheese(matrix))
                {
                    if (matrix[playerRow + 1, playerCol] == 'C')
                    {
                        matrix[playerRow + 1, playerCol] = 'M';

                    }
                    else if (matrix[playerRow + 1, playerCol] == 'T')
                    {

                        Console.WriteLine("Mouse is trapped!");
                        matrix[playerRow + 1, playerCol] = 'M';
                        PrintMatrix(matrix);
                        return;
                    }
                    else if (matrix[playerRow, playerCol - 1] == '*')
                    {
                        matrix[playerRow + 1, playerCol] = 'M';
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    matrix[playerRow + 1, playerCol] = 'M';
                    matrix[playerRow, playerCol] = '*';

                    PrintMatrix(matrix);
                    return;

                }

                matrix[playerRow + 1, playerCol] = 'M';

                playerRow++;
            }

            else
            {
                Console.WriteLine("No more cheese for tonight!");
                matrix[playerRow, playerCol] = 'M';

                PrintMatrix(matrix);
                return;
            }
            break;
        case "left":
            if (ValidateMove(playerRow, playerCol - 1, matrix))
            {
                matrix[playerRow, playerCol] = '*';

                if (Cheese(matrix))
                {
                    if (matrix[playerRow, playerCol - 1] == 'C')
                    {
                        matrix[playerRow, playerCol - 1] = 'M';

                    }
                    else if (matrix[playerRow, playerCol - 1] == 'T')
                    {

                        Console.WriteLine("Mouse is trapped!");
                        matrix[playerRow, playerCol - 1] = 'M';
                        PrintMatrix(matrix);
                        return;
                    }
                    else if (matrix[playerRow, playerCol - 1] == '*')
                    {
                        matrix[playerRow, playerCol - 1] = 'M';
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    matrix[playerRow, playerCol - 1] = 'M';

                    PrintMatrix(matrix);
                    return;
                }

                matrix[playerRow, playerCol - 1] = 'M';

                playerCol--;
            }
            else
            {
                Console.WriteLine("No more cheese for tonight!");
                matrix[playerRow, playerCol] = 'M';

                PrintMatrix(matrix);
                return;
            }
            break;
        case "right":
            if (ValidateMove(playerRow, playerCol + 1, matrix))
            {
                matrix[playerRow, playerCol] = '*';

                if (Cheese(matrix))
                {
                    if (matrix[playerRow, playerCol + 1] == 'C')
                    {
                        matrix[playerRow, playerCol + 1] = 'M';

                    }
                    else if (matrix[playerRow, playerCol + 1] == 'T')
                    {

                        Console.WriteLine("Mouse is trapped!");
                        matrix[playerRow, playerCol + 1] = 'M';
                        PrintMatrix(matrix);
                        return;
                    }
                    else if (matrix[playerRow, playerCol + 1] == '*')
                    {
                        matrix[playerRow, playerCol + 1] = 'M';
                        continue;
                    }
                }
                else
                {

                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    matrix[playerRow, playerCol + 1] = 'M';

                    PrintMatrix(matrix);
                    return;
                }

                matrix[playerRow, playerCol + 1] = 'M';

                playerCol++;
            }
            else
            {
                Console.WriteLine("No more cheese for tonight!");
                matrix[playerRow, playerCol] = 'M';

                PrintMatrix(matrix);
                return;
            }
            break;



        default:
            break;
    }
}
Console.WriteLine("Mouse will come back later!");
PrintMatrix(matrix);



bool Cheese(char[,] matrix)
{

    for (int row = 0; row < matrix.GetLength(0); row++)
    {

        for (int col = 0; col < matrix.GetLength(1); col++)
        {


            if (matrix[row, col] == 'C')
            {
                return true;
            }

        }
    }
    return false;
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
        && col >= 0 && col < matrix.GetLength(1)
        && matrix[row, col] != '@';

    return result;
}