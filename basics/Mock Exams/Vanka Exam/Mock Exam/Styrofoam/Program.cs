namespace Styrofoam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            double areaHouse = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double areaStyrofoam = double.Parse(Console.ReadLine());    
            double pricePackage = double.Parse(Console.ReadLine());


            double totalArea = (areaHouse - (windows * 2.4));
            double firaArea = (totalArea+(0.1*totalArea));

            Console.WriteLine(firaArea);


            double styrofoamNeeded = Math.Ceiling(firaArea/areaStyrofoam);
            Console.WriteLine(styrofoamNeeded);
            double price = styrofoamNeeded * pricePackage;
            Console.WriteLine(price);

            if (budget>price)
            {
                Console.WriteLine("Spent: {0:f2}",price);
                Console.WriteLine("Left:{0:F2}",budget-price);
            }
            else
            {
                Console.WriteLine("Need more: {0:F2}",price-budget);
            }

        }
    }
}