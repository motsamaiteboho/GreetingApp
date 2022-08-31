public class TestGreetedUser
{
    [Fact]
    public void ShouldReturnNamesOfGreetedUser()
    {
        Greet.GreetUser("Teboho", "1");
        Assert.Equal("TEBOHO  has been greeted 2 times",GreetedUser.UserCount("TEBOHO"));
    }
}