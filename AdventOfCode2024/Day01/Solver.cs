using AdventOfCode2024.Utils;

namespace AdventOfCode2024.Day01
{
    public class Solver(string input) : ISolver
    {
        private readonly string _input = input;

        public string Part1()
        {
            var col1 = GetColumn(0).Order().ToList();
            var col2 = GetColumn(1).Order().ToList();

            var total = 0;
            for (int i = 0; i < col1.Count(); i++)
            {
                total += Math.Abs(col2[i] - col1[i]);
            }
            return total.ToString();
        }

        public string Part2()
        {
            var col1 = GetColumn(0);
            var col2 = GetColumn(1);

            var total = 0;
            for (int i = 0; i < col1.Count(); i++)
            {
                var multiplier = col2.Where(x => x == col1[i]).Count();
                total += col1[i] * multiplier;
            }
            return total.ToString();
        }

        public List<int> GetColumn(int col)
        {
            return _input.AsList().Select(i => int.Parse(i.Split(' ', StringSplitOptions.RemoveEmptyEntries)[col])).ToList();
        }
    }
}
