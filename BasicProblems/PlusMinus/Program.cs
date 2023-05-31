int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine()
    .TrimEnd()
    .Split(' ')
    .ToList()
    .Select(arrTemp => Convert.ToInt32(arrTemp))
    .ToList();

int positiveCount = 0;
int negativeCount = 0;
int zeroCount = 0;

foreach (var element in arr)
{
    if (element > 0)
    {
        positiveCount++;
    }
    else if (element < 0)
    {
        negativeCount++;
    }
    else
    {
        zeroCount++;
    }
}

decimal negativeRatio = (decimal)negativeCount / arr.Count;
decimal positiveRatio = (decimal)positiveCount / arr.Count;
decimal zeroRatio = (decimal)zeroCount / arr.Count;

Console.WriteLine($"{positiveRatio:F6}");
Console.WriteLine($"{negativeRatio:F6}");
Console.WriteLine($"{zeroRatio:F6}");
