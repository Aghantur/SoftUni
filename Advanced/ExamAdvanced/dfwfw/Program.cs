using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] dimensions = input.Split(',');
        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);

        char[,] matrix = new char[rows, cols];
        int mouseRow = -1;
        int mouseCol = -1;
        int cheeseCount = 0;

        for (int row = 0; row < rows; row++)
        {
            string line = Console.ReadLine();

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = line[col];

                if (matrix[row, col] == 'M')
                {
                    mouseRow = row;
                    mouseCol = col;
                }
                else if (matrix[row, col] == 'C')
                {
                    cheeseCount++;
                }
            }
        }

        string command = Console.ReadLine();

        while (command != "danger")
        {
            int newMouseRow = mouseRow;
            int newMouseCol = mouseCol;

            if (command == "up")
            {
                newMouseRow--;
            }
            else if (command == "down")
            {
                newMouseRow++;
            }
            else if (command == "left")
            {
                newMouseCol--;
            }
            else if (command == "right")
            {
                newMouseCol++;
            }

            if (!IsValidPosition(newMouseRow, newMouseCol, rows, cols))
            {
                Console.WriteLine("No more cheese for tonight!");
                PrintMatrix(matrix, rows, cols);
                return;
            }

            char newPosition = matrix[newMouseRow, newMouseCol];

            if (newPosition == '@')
            {
                command = Console.ReadLine();
                continue;
            }
            else if (newPosition == 'C')
            {
                cheeseCount--;
                if (cheeseCount == 0)
                {
                    matrix[mouseRow, mouseCol] = '*';

                    matrix[newMouseRow, newMouseCol] = 'M';
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    PrintMatrix(matrix, rows, cols);
                    return;
                }
                else
                {
                    matrix[newMouseRow, newMouseCol] = '*';
                }
            }
            else if (newPosition == 'T')
            {
                matrix[mouseRow, mouseCol] = '*';

                matrix[newMouseRow, newMouseCol] = 'M';
                Console.WriteLine("Mouse is trapped!");
                PrintMatrix(matrix, rows, cols);
                return;
            }

            matrix[mouseRow, mouseCol] = '*';
            matrix[newMouseRow, newMouseCol] = 'M';
            mouseRow = newMouseRow;
            mouseCol = newMouseCol;

            command = Console.ReadLine();
        }

        Console.WriteLine("Mouse will come back later!");
        PrintMatrix(matrix, rows, cols);
    }

    static bool IsValidPosition(int row, int col, int rows, int cols)
    {
        return row >= 0 && row < rows && col >= 0 && col < cols;
    }

    static void PrintMatrix(char[,] matrix, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
