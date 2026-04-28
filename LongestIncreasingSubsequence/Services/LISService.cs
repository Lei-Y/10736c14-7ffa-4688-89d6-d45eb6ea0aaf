namespace LongestIncreasingSubsequence.Services
{
    public class LISService : ILISService
    {
        public string GetLongestIncreasingRun(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }
            var numbers = new List<int>();
            foreach (var x in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (!int.TryParse(x, out int result))
                {
                    //Validate input, it should be a string of space separated integers
                    throw new ArgumentException($"Invalid input: {x} is not an integer.");
                }
                numbers.Add(result);
            }

            return GetLongestIncreasingRun(numbers.ToArray());
        }

        private string GetLongestIncreasingRun(int[] input)
        {
            if (input.Length == 0)
            {
                return string.Empty;
            }

            if (input.Length == 1)
            {
                return input[0].ToString();
            }

            var index = 0;
            var len = 1;
            var currentIndex = 0;
            var currentLen = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] < input[i])
                {
                    currentLen++;
                }
                else
                {
                    currentIndex = i;
                    currentLen = 1;
                }
                if (currentLen > len)
                {
                    index = currentIndex;
                    len = currentLen;
                }
            }

            return string.Join(" ", input[index..(index + len)]);
        }
    }
}
