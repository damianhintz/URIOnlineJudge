using System;
using FluentAssertions;
using NUnit.Framework;
using Problem2165;

namespace Beginner.Testy
{
    [TestFixture]
    public class Problem2165Tests
    {
        [Test]
        public void Text140InLengthIsTweet()
        {
            var solver = new ProblemSolver2165();
            var text141Length = new string('t', 140);
            var answer = solver.IsTweet(text141Length);
            answer.Should().BeTrue();
        }

        [Test]
        public void TextLongerThan140IsNotTweet()
        {
            var solver = new ProblemSolver2165();
            var text141Length = new string('t', 141);
            var answer = solver.IsTweet(text141Length);
            answer.Should().BeFalse();
        }
    }
}
