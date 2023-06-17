namespace _01.ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> items = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();
            ListyIterator<string> listy = new(items);

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Print":
                        listy.Print();
                        break;
                    case "PrintAll":
                        foreach (var item in listy)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}