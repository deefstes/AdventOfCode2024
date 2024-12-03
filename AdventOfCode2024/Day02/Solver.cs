using AdventOfCode2024.Utils;

namespace AdventOfCode2024.Day02
{
    public class Solver(string input) : ISolver
    {
        private readonly string _input = input;

        public string Part1()
        {
            int safeLines = 0;
            foreach (var line in _input.AsList())
            {
                if (IsSafe(line))
                    safeLines++;
            }

            return safeLines.ToString();
        }

        public string Part2()
        {
            int safeLines = 0;
            foreach (var line in _input.AsList())
            {
                if (IsSafe(line))
                    safeLines++;
                else
                {
                    foreach (var dampened in DampenerAttempts(line).ToList())
                    {
                        if (IsSafe(dampened))
                        {
                            safeLines++;
                            break;
                        }
                    }
                }
            }

            return safeLines.ToString();
        }

        public static bool IsSafe(string input)
        {
            bool? incrementing = null;
            int lastVal = 0;

            foreach (int val in input.Split(' ').Select(i=>int.Parse(i)))
            {
                if (lastVal == 0)
                {
                    lastVal = val;
                }
                else
                {
                    incrementing ??= val > lastVal;

                    if (val > lastVal != incrementing)
                        return false;

                    if (Math.Abs(val - lastVal) < 1 || Math.Abs(val - lastVal) > 3)
                        return false;

                    lastVal = val;
                }
            }

            return true;
        }

        public static IEnumerable<string> DampenerAttempts(string line)
        {
            var vals = line.Split(' ');

            for (int i = 0; i < vals.Length; i++)
            {
                yield return string.Join(" ", vals.Where((item, index) => index != i));
            }
        }
    }
}
