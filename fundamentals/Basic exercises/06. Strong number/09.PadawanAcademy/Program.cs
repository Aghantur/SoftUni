using System;

class JediAcademy
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        double lightsaberPrice = double.Parse(Console.ReadLine());
        double robePrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());

        double lightsabers = Math.Ceiling(students * 1.1);

        double belts = students - (students / 6);

        double totalCost = (lightsabers * lightsaberPrice) + (belts * beltPrice) + (students * robePrice);

        if (money >= totalCost)
        {
            Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
        }
        else
        {
            Console.WriteLine($"John will need {totalCost - money:F2}lv more.");
        }
    }
}
