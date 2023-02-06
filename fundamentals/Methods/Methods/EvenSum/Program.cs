namespace EvenSum
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int numberAsString = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;


            while (numberAsString > 0)
            {
                int currNumber = numberAsString % 10;

                if (currNumber % 2 == 0)
                {
                    sumEven += currNumber;
                }
                else
                {
                    sumOdd += currNumber;
                }
                numberAsString /= 10;
            }
            Console.WriteLine(sumOdd * sumEven);
        }


    }
}