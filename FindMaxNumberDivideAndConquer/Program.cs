
int[] arr = new int[] { 2, 1, 4, 5, 7, 71, 11 };
Console.WriteLine(FindMaxSum(arr, 0, arr.Length - 1));
static int FindMaxSum(int[] array, int left, int right)
{
    if (left == right)
        return array[left];

    int mid = (left + right) / 2;


    int leftSum = FindMaxSum(array, left, mid);
    int rightSum = FindMaxSum(array, mid + 1, right);
    int crossingSum = CrossingSummary(array, left, right, mid);
    return Math.Max(leftSum, Math.Max(rightSum, crossingSum));

}
static int CrossingSummary(int[] arr, int left, int right, int mid)
{
    int leftSum = 0;
    for (int i = left; i <= mid; i++)
    {
        leftSum += arr[i];
    }
    int rightSum = 0;
    for (int i = mid + 1; i <= right; i++)
    {
        rightSum += arr[i];
    }
    return leftSum + rightSum;
}