using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace AdventOfCode2024.Day03
{
    public class Solver(string input) : ISolver
    {
        private readonly string _input = input;

        public string Part1()
        {
            var pattern = @"mul\((\d{1,3}),(\d{1,3})\)";
            var matches = Regex.Matches(_input, pattern);

            var runningTotal = 0;
            foreach (Match match in matches)
            {
                runningTotal += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
            }

            return runningTotal.ToString();
        }

        public string Part2()
        {
            var pattern = @"mul\((\d{1,3}),(\d{1,3})\)|do\(\)|don't\(\)";
            var matches = Regex.Matches(_input, pattern);

            var runningTotal = 0;
            bool enabled = true;
            foreach (Match match in matches)
            {
                if (match.Value == "do()")
                    enabled = true;
                else if (match.Value == "don't()")
                    enabled = false;
                else if (enabled)
                    runningTotal += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
            }

            return runningTotal.ToString();
        }
    }
}
