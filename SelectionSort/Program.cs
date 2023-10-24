int[] array = new int[] { 3, 1, 4, 5, 26, 11 };

for (int i = 1; i < array.Length; i++)
{
    int minIndex = i - 1;
    for (int j = i; j < array.Length; j++)
    {
        if (array[minIndex] > array[j])
        {
            minIndex = j;
        }
    }
    int temp = array[i - 1];
    array[i - 1] = array[minIndex];
    array[minIndex] = temp;
}

array.ToList().ForEach(x => Console.WriteLine(x));
