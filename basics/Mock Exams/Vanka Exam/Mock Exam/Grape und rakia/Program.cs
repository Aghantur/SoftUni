namespace Grape_und_rakia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double kgGrape = double.Parse(Console.ReadLine());  
            double brak = double.Parse(Console.ReadLine()); 

            double grapeTotal = (area*kgGrape)-brak;

            double rakiaKG = grapeTotal * 0.45;

            double forsaleKG = grapeTotal-rakiaKG;
            double rakiaProduct = rakiaKG / 7.5;
            double rakiaPrihod = rakiaProduct * 9.8;

            Console.WriteLine($"{rakiaPrihod:F2}");

            double prihod = forsaleKG * 1.5;
            Console.WriteLine($"{prihod:F2}");


        }
    }
}