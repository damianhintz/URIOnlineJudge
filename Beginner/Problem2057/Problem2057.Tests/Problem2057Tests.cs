using Problem2057.Solution;

namespace Problem2057.Tests;

public class Problem2057Tests
{
    [Fact]
    public void Test1()
    {
        var result = URI.GetLocalTime(0, 0, 0);
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(10, 7, 3, 20)]
    [InlineData(22, 6, -2, 2)] //22 6 -2 2
    [InlineData(0, 3, -4, 23)] //0 3 -4 23
    [InlineData(0, 0, 0, 0)]
    [InlineData(0, 12, 5, 17)]
    [InlineData(0, 12, -5, 7)]
    [InlineData(0, 1, -5, 20)]
    [InlineData(23, 1, 0, 0)]
    [InlineData(23, 12, 5, 16)]
    [InlineData(23, 12, -5, 6)]
    //S (0 ≤ S ≤ 23), T (1 ≤ T ≤ 12) y F (-5 ≤ F ≤ 5)
    public void Test2(int x, int y, int z, int expected)
    {
        var result = URI.GetLocalTime(x, y, z);
        Assert.Equal(expected, result);

        var result2 = URI.GetLocalTimeArray(x, y, z);
        Assert.Equal(expected, result2);
    }
}