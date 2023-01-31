using System.Globalization;

int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
//int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < arr.Length; i++)
{
    int numbers = int.Parse(Console.ReadLine());
    arr[i] = numbers;

}
for (int i = arr.Length - 1; i >= 0; i--)
{
    Console.Write(arr[i] + " ");
}
// int[] reversed = number.Revers().ToArray();

