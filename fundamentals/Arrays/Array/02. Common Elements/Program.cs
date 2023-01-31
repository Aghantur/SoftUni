string[] arr = Console.ReadLine().Split();
string[] arr2 = Console.ReadLine().Split();

for (int i = 0; i < arr2.Length; i++)
{
    string currEle = arr2[i];
    for (int j = 0; j < arr.Length; j++)
    {
        if (currEle == arr[j])
        {
            Console.Write(currEle + " ");
        }
    }
}