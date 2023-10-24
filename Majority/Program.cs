
int[] arr = { 5,5, 2, 5, 3, 5, 1 };
int n = arr.Length;
FindMajority(arr, n);

static void FindMajority(int[] arr, int n)
{
    int maxCount = 0;
    int index = -1;

    for (int i = 0; i < n; i++)
    {
        int count = 1;

        for (int j = i + 1; j < n; j++)
        {
            if (arr[i] == arr[j])
            {
                count++;
            }
        }

        if (count > maxCount)
        {
            maxCount = count;
            index = i;
        }
    }

    if (maxCount > n / 2)
    {
        Console.WriteLine(arr[index]);
    }
    else
    {
        Console.WriteLine("No Majority Element");
    }
}



