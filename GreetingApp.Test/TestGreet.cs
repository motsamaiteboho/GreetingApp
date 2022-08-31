namespace GreetingApp.Test;

public class TestGreet
{
    [Fact]
    public void ShouldReturnTheGreetingInSpecifiedLangage()
    {
        Assert.Equal("Hello, Teboho",Greet.GreetUser("Teboho", "1"));
    }
}