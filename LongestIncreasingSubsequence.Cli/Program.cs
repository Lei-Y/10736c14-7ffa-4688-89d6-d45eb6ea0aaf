using LongestIncreasingSubsequence.Services;

if (args.Length == 0)
{
    Console.Error.WriteLine("Enter integers separated by spaces:");
}

var input = args.Length > 0
    ? string.Join(' ', args)
    : Console.ReadLine() ?? "";

var service = new LISService();
Console.WriteLine(service.GetLongestIncreasingRun(input));
