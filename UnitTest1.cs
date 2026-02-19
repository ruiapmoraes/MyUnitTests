namespace MyUnitTests;

public class UnitTest1
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    [Fact]
    public void Good() => 
        Assert.Equal(4, Add(2,2));

    [Fact]
    public void Bad() => 
        Assert.Equal(3, Add(2,2));

}
