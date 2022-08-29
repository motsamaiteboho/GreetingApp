public class GreetedUsers
{
    Dictionary<string,int> users;
    public GreetedUsers(Dictionary<string,int> users)
    {
        this.users = users;
    }

    public void GetGreetedUsers()
    {
        foreach(var user in users)
        {
            Console.Clear();
            Console.WriteLine("GREETED USERS");
            Console.WriteLine("======================");
            Console.WriteLine("Username : Count");
            Console.WriteLine($"{user.Key} : {user.Value}");
        }
    }

}