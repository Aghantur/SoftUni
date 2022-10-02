namespace SchoolMaterials
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int pencils = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());    
            int litreChemical = int.Parse(Console.ReadLine());

            double discountRate =double.Parse(Console.ReadLine())/100;

            double pencilSum = pencils * 5.8;
            double markerSum = markers * 7.2;
            double litreSum = litreChemical * 1.2;

            double totalSum= (pencilSum + markerSum + litreSum)-((pencilSum + markerSum+ litreSum)*discountRate);
            Console.WriteLine(totalSum);



        }
    }
}