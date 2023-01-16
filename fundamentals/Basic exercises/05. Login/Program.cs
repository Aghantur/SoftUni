namespace _05._Login
{
    using System;
    using System.Linq;
    public class Program
    {
        static void Main(string[] args)
        {
          

            string username = Console.ReadLine()!;

            string password = new string(username.Reverse().ToArray());
            int countFailed = 0;
           
            
            while (true)
            {
                string providedpass = Console.ReadLine()!;

                if (providedpass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else 
                {
                    countFailed++;
                    Console.WriteLine("Incorrect password. Try again.");
                }

                if (countFailed==3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

            }

        }
    }
}