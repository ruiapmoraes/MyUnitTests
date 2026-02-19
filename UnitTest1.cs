namespace MyUnitTests;

public class UnitTest1
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    bool isOdd(int n) => n % 2 == 1;

    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(6)]
    public void MyFirstTheory(int value) =>
        Assert.True(isOdd(value));

    [Fact]
    public void Good() => 
        Assert.Equal(4, Add(2,2));

    [Fact]
    public void Bad() => 
        Assert.Equal(3, Add(2,2));
        

}
