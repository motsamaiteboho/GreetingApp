

public class TestGreetedUsers
{
    [Fact]
    public void ShouldReturnNamesOfGreetedUsers()
    {
        Greet.GreetUser("Thabo", "1");
        Assert.Equal("TEBOHO : 2 \nTHABO : 1 \n",GreetedUsers.GetGreetedUsers());
    }
}