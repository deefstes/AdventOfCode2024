using AdventOfCode2024.Utils;
using static System.Net.Mime.MediaTypeNames;

namespace AdventOfCode2024.Day04
{
    public class Solver(string input) : ISolver
    {
        private readonly string _input = input;

        public string Part1()
        {
            var grid = _input.AsGrid();

            var count = 0;

            foreach (var row in grid.GetRowStrings())
            //for (var x = 0; x < grid.GetLength(0); x++)
            {
                //var row = grid.RowToString(x);
                count += CountSubstrings(row, "XMAS");
                count += CountSubstrings(row, "SAMX");
                //count += CountSubstrings(new string(row.Reverse().ToArray()), "XMAS");
            }

            foreach (var col in  grid.GetColStrings())
            //for (var y = 0; y < grid.GetLength(1); y++)
            {
                //var col = grid.ColToString(y);
                count += CountSubstrings(col, "XMAS");
                count += CountSubstrings(col, "SAMX");
                //count += CountSubstrings(new string(col.Reverse().ToArray()), "XMAS");
            }

            foreach (var diag in  grid.GetDiagStrings())
            //foreach (var diag in GetAllDiagonals(grid))
            {
                count += CountSubstrings(diag, "XMAS");
                count += CountSubstrings(diag, "SAMX");
                //count += CountSubstrings(new string(diag.Reverse().ToArray()), "XMAS");
            }

            return count.ToString();
        }

        public string Part2()
        {
            var grid = _input.AsGrid();
            var count = 0;

            for (var x = 1; x < grid.GetLength(0) - 1; x++)
                for (var y = 1; y < grid.GetLength(1) - 1; y++)
                {
                    if (grid[x, y] == 'A')
                    {
                        if (
                            (grid[x - 1, y - 1] == 'M' && grid[x + 1, y + 1] == 'S' || grid[x - 1, y - 1] == 'S' && grid[x + 1, y + 1] == 'M')
                            && (grid[x + 1, y - 1] == 'M' && grid[x - 1, y + 1] == 'S' || grid[x + 1, y - 1] == 'S' && grid[x - 1, y + 1] == 'M')
                            )
                        {
                            count++;
                        }
                    }
                }
            
            return count.ToString();
        }

        public static int CountSubstrings(string input, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = input.IndexOf(substring, index, StringComparison.Ordinal)) != -1)
            {
                count++;
                index += substring.Length; // Move index forward by the length of the substring
            }

            return count;
        }
    }
}
