using AdventOfCode2024.Day02;
using NUnit.Framework;

namespace AdventOfCode2024.Tests.Day02
{
    [TestFixture()]
    public class SolverTests
    {
        [Test()]
        public void Part1Test()
        {
            Solver solver = new(File.ReadAllText($"Day02\\sample.txt"));
            var rsp = solver.Part1();

            Assert.That(rsp, Is.EqualTo("2"));
        }

        [Test()]
        public void Part2Test()
        {
            Solver solver = new(File.ReadAllText($"Day02\\sample.txt"));
            var rsp = solver.Part2();

            Assert.That(rsp, Is.EqualTo("4"));
        }
    }
}