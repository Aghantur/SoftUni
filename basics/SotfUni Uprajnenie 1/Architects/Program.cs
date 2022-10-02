namespace Architects
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hours = projects * 3;


            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.",name,hours, projects);

        }
    }
}