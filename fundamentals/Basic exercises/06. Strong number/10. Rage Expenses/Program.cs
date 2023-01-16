using System;

class RageExpenses
{
    static void Main()
    {
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine()); 
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        double expenses = 0;

        int trashedHeadsets = lostGames / 2;
        int trashedMice = lostGames / 3;
        int trashedKeyboards = lostGames / 6;
        int trashedDisplays = trashedKeyboards / 2;

        expenses += trashedHeadsets * headsetPrice;
        expenses += trashedMice * mousePrice;
        expenses += trashedKeyboards * keyboardPrice;
        expenses += trashedDisplays * displayPrice;

        Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
    }
}
