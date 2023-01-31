
int n = int.Parse(Console.ReadLine());

int[] days = new int[n];

for (int i = 0; i < days.Length; i++) 
{
    int input = int.Parse(Console.ReadLine());
    days[i] = input;


}

for (int i = 0; i < days.Length; i++)
{
    Console.WriteLine(days[i]);
}