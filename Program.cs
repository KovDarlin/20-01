
var Numbers = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
{
    {"zero", 0 },{"one", 1 },
    {"two", 2 },{"three", 3 },
    {"four", 4 },{"five", 5 },
    {"six", 6 },{"seven", 7 },
    {"eight", 8 },{"nine", 9 } };
while (true)
{
    Console.WriteLine("Enter word number - ");
    string input = Console.ReadLine()?.Trim().ToLower();
    if(Numbers.TryGetValue(input, out int num))
    {
        Console.WriteLine($"Number: {num}");
    }
    else
    {
        Console.WriteLine("Not correct. Error!");
    }
}
