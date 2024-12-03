﻿using AdventOfCode2024.Day09;
using NUnit.Framework;

namespace AdventOfCode2024.Tests.Day09
{
    [TestFixture()]
    public class SolverTests
    {
        [Test()]
        public void Part1Test()
        {
            Solver solver = new(File.ReadAllText($"Day09\\sample.txt"));
            var rsp = solver.Part1();

            Assert.That(rsp, Is.EqualTo(""));
        }

        [Test()]
        public void Part2Test()
        {
            Solver solver = new(File.ReadAllText($"Day09\\sample.txt"));
            var rsp = solver.Part2();

            Assert.That(rsp, Is.EqualTo(""));
        }
    }
}