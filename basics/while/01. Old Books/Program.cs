namespace _01._Old_Books
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            string searchBook = Console.ReadLine();

            int booksCount = 0;
            bool isFound = false;

            string bookName;


            while ((bookName = Console.ReadLine()) != "No More Books")
            {

                if (bookName==searchBook)
                {
                    isFound = true;
                    break;
                }


                booksCount++;

            }

            if (isFound)
            {
                Console.WriteLine($"You checked {booksCount} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {booksCount} books.");
            }


        }
    }
}