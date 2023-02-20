int days = int.Parse(Console.ReadLine());
int dailyPlunder = int.Parse(Console.ReadLine());
double targetPlunder = double.Parse(Console.ReadLine());

double sum = 0;


for (int i = 1; i <= days; i++)
{
    sum += dailyPlunder;

    if (i % 3 == 0)
    {
        sum += 0.5 * dailyPlunder;
    }

    if (i % 5 == 0)
    {
        sum *= 0.7;
    }
}

if (sum >= targetPlunder)
{
    Console.WriteLine($"Ahoy! {sum:f2} plunder gained.");
}
else
{
    Console.WriteLine($"Collected only {sum / targetPlunder * 100:f2}% of the plunder.");
}