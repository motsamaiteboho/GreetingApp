public static class GreetedUsers
{
    static Dictionary<string,int> users = InMemoryUsers.getUsers();
    

    public static void GetGreetedUsers()
    {
        Console.Clear();
        Console.WriteLine("GREETED USERS");
        Console.WriteLine("======================");
        foreach(var user in users)
        {
            Console.WriteLine($"{user.Key} : {user.Value}");
        }
    }

}
