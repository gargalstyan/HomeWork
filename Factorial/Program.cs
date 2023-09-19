Console.WriteLine("Enter n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Factorial(n));
static double Factorial(int n)
{
    if (n <= 0)
        return 0;
    else if (n == 1)
        return 1;
    else
    {
        return n * Factorial(n - 1);
    }
}