int[] openKey = Console.ReadLine().Split(" ").Select(o => Int32.Parse(o)).ToArray();
int result = 0;
if (openKey.Max() % openKey.Min() == 0)
{
    int a = openKey.Max() / openKey.Min();
    for (int i = 1; i <= a; i++)
    {
        if (a % i == 0 && i % (a / i) == 0) result++;
    }
}
Console.WriteLine((result * 2).ToString());