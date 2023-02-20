int cookiesPerWorker = int.Parse(Console.ReadLine());
int numberOfWorkers = int.Parse(Console.ReadLine());
long biscuitsPerMonth = long.Parse(Console.ReadLine());


double perDay = numberOfWorkers * cookiesPerWorker;


double result = (20 * numberOfWorkers * cookiesPerWorker) + (double)Math.Floor(10.0 * numberOfWorkers * cookiesPerWorker * 75 / 100);
Console.WriteLine($"You have produced {result} biscuits for the past month.");

if (result > biscuitsPerMonth)
{
    Console.WriteLine($"You produce {(result - biscuitsPerMonth) / biscuitsPerMonth * 100:f2} percent more biscuits.");
}
else
{
    Console.WriteLine($"You produce {(biscuitsPerMonth - result) / biscuitsPerMonth * 100:f2} percent less biscuits.");
}