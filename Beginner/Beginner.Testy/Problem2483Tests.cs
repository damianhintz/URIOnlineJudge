using FluentAssertions;
using NUnit.Framework;
using Problem2483;

namespace Beginner.Testy
{
    [TestFixture]
    public class Problem2483Tests
    {
        [Test]
        public void Given_HappinessIndexIsOne_When_WeWantToKnowMerryChristmasInPortuguese_Then_ShouldBeFelizNatal()
        {
            var solver = new ProblemSolver2483();

            var answer = solver.GetMerryChristmasInPortuguese(1);

            answer.Should().Be("Feliz natal!");
        }

        [Test]
        public void Given_HappinessIndexIsTwo_When_WeWantToKnowMerryChristmasInPortuguese_Then_ShouldBeFelizNataal()
        {
            var solver = new ProblemSolver2483();

            var answer = solver.GetMerryChristmasInPortuguese(2);

            answer.Should().Be("Feliz nataal!");
        }
    }
}
