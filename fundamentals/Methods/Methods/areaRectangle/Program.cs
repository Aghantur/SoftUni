namespace areaRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = getArea(width, height);

            Console.WriteLine(area);
        }

        private static double getArea(double width, double height)
        {
            double result = width * height;

            return result;


        }
    }
}