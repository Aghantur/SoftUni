namespace DepositCalc
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            double deposit = double.Parse(Console.ReadLine());
            int months= int.Parse(Console.ReadLine());
            double percentInterest = double.Parse(Console.ReadLine())/100;

            double monthRate = (deposit * percentInterest) /12;
             

            double totalDeposit = deposit + (months * monthRate);
            Console.WriteLine(totalDeposit);

        }
    }
}