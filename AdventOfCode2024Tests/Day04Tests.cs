using AdventOfCode2024.Day04;
using NUnit.Framework;

namespace AdventOfCode2024.Tests.Day04
{
    [TestFixture()]
    public class SolverTests
    {
        [Test()]
        public void Part1Test()
        {
            Solver solver = new(File.ReadAllText($"Day04\\sample.txt"));
            var rsp = solver.Part1();

            Assert.That(rsp, Is.EqualTo("18"));
        }

        [Test()]
        public void Part2Test()
        {
            Solver solver = new(File.ReadAllText($"Day04\\sample.txt"));
            var rsp = solver.Part2();

            Assert.That(rsp, Is.EqualTo("9"));
        }
    }
}