
int n = int.Parse(Console.ReadLine());


int[] arr = new int[n];
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    int ppl = int.Parse(Console.ReadLine());
    arr[i] = ppl;
    sum += ppl;
}
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(sum);