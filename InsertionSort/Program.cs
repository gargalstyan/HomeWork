int[] array = new int[] { 3, 1, 4, 5, 26, 11 };
for (int i = 1; i < array.Length; i++)
{
    for (int j = i; j > 0; j--)
    {
        if (array[j] < array[j - 1])
        {
            int temp = array[j];
            array[j] = array[j - 1];
            array[j - 1] = temp;
        }
    }
}
array.ToList().ForEach(x => Console.WriteLine(x));