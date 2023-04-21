using Problem2126.Solution;

namespace Problem2126.XUnitTests;

public class UnitTest1
{
    [Fact]
    public void TestCase1()
    {
        var result = Program.SolveProblem("78954", "7895478954789547895447895478954");
        Assert.Equal(result.NumberOfSubstrings, 6);
        Assert.Equal(result.LastSubstringIndex, 27);
    }

    [Fact]
    public void TestCase2()
    {
        var result = Program.SolveProblem("464133", "1331646546874694");
        Assert.Equal(result.NumberOfSubstrings, 0);
        Assert.Equal(result.LastSubstringIndex, 0);
    }

    [Fact]
    public void TestCase3()
    {
        var result = Program.SolveProblem("12", "1231321455123214565423112");
        Assert.Equal(result.NumberOfSubstrings, 3);
        Assert.Equal(result.LastSubstringIndex, 24);
    }

    [Fact]
    public void TestCase4()
    {
        var result = Program.SolveProblem("1", "11111");
        Assert.Equal(result.NumberOfSubstrings, 5);
        Assert.Equal(result.LastSubstringIndex, 5);
    }
}