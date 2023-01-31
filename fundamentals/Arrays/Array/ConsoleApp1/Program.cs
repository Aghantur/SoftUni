string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

int daysread = int.Parse(Console.ReadLine());

if (daysread >= 1 && daysread <= 7)
{
    Console.WriteLine(days[daysread - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}



int[] test = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < test.Length; i++)
{
    Console.WriteLine(test[i]);
}