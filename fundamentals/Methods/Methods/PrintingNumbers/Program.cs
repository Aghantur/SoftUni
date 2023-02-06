namespace PrintingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintNum(i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintNum(i);
            }

        }

        static void PrintNum(int end)
        {
            for (int j = 1; j <= end; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();

        }
    }
}