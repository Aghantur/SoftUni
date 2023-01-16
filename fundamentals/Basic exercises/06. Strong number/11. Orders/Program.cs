using System;

class Orders
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); 
        double totalPrice = 0; 

        for (int i = 0; i < n; i++)
        {
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());

            double orderPrice = (days * capsulesCount) * pricePerCapsule;

            totalPrice += orderPrice;

            Console.WriteLine("The price for the coffee is: ${0:F2}", orderPrice);
        }

        Console.WriteLine("Total: ${0:F2}", totalPrice);
    }
}
