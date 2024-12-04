using AdventOfCode2024.Day03;
using NUnit.Framework;

namespace AdventOfCode2024.Tests.Day03
{
    [TestFixture()]
    public class SolverTests
    {
        [Test()]
        public void Part1Test()
        {
            Solver solver = new(File.ReadAllText($"Day03\\sample1.txt"));
            var rsp = solver.Part1();

            Assert.That(rsp, Is.EqualTo("161"));
        }

        [Test()]
        public void Part2Test()
        {
            Solver solver = new(File.ReadAllText($"Day03\\sample2.txt"));
            var rsp = solver.Part2();

            Assert.That(rsp, Is.EqualTo("48"));
        }
    }
}