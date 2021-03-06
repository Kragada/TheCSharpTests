using Xunit;

namespace TheCSharpTests
{
public class testclass{

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void MyFirstTheory(int mynumber){
        Assert.True(Program.IsOdd(mynumber));
    }

    [Fact]
    public void PassingAddTest(){
        Assert.Equal(8, Program.Add(4,4));
    }
    [Fact]
    public void FailingAddTest(){
        Assert.NotEqual(5, Program.Add(2,2));
    }
}
}