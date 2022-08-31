public static class GreetedUsers
{
    static Dictionary<string,int> users = InMemoryUsers.getUsers();
    

    public static string GetGreetedUsers()
    {
        string sResult = string.Empty;
        Console.Clear();
        Console.WriteLine("GREETED USERS");
        Console.WriteLine("======================");
        foreach(var user in users)
        {
            sResult += $"{user.Key} : {user.Value} \n";
        }
        return sResult;
    }
  
}
