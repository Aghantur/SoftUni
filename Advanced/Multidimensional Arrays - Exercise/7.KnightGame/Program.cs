int size = int.Parse(Console.ReadLine());

if (size < 3 )
{
    Console.WriteLine(0);

    return;
}

char[,] matrix = new char[size, size];

for (int row = 0; row < size; row++)
{
    string chars = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = chars[col];
    }
}
int knightsRemoved = 0;
while (true)
{
    int mostAtk = 0;
    int rowMostAtk = 0;
    int colMostAtk = 0;

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (matrix[row,col] == 'K')
            {
                int attackedKnight = CountAttackKnights(row, col, size, matrix);

                if (mostAtk < attackedKnight)
                {
                    mostAtk = attackedKnight;
                    rowMostAtk = row;
                    colMostAtk = col;
                }
            }
        }
    }

    if (mostAtk == 0)
    {
        break;
    }
    else
    {
        matrix[rowMostAtk, colMostAtk] = '0';
        knightsRemoved++;
    }
}
Console.WriteLine(knightsRemoved);

static int CountAttackKnights(int row, int col, int size, char[,] matrix)
{
    int attackedKnights = 0;
    //horizontal
    if (IsCellValid(row - 1, col - 2, size))
    {
        if (matrix[row - 1, col - 2] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row + 1, col + 2, size))
    {
        if (matrix[row + 1, col + 2] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row - 1, col + 2, size))
    {
        if (matrix[row - 1, col + 2] == 'K')
        {
            attackedKnights++;
        }
    }

    if (IsCellValid(row + 1, col - 2, size))
    {
        if (matrix[row + 1, col - 2] == 'K')
        {
            attackedKnights++;
        }
    }
    //vertical down-left
    if (IsCellValid(row + 2, col - 1, size))
    {
        if (matrix[row + 2, col - 1] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row + 2, col + 1, size))
    {
        if (matrix[row + 2, col + 1] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row - 2, col - 1, size))
    {
        if (matrix[row - 2, col - 1] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row - 2, col + 1, size))
    {
        if (matrix[row - 2, col + 1] == 'K')
        {
            attackedKnights++;
        }
    }
    return attackedKnights;
}

static bool IsCellValid(int row, int col, int size)
{
    return
        row >= 0
        && row < size
        && col >= 0
        && col < size;   
}