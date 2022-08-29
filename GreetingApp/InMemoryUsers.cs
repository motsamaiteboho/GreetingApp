public static class InMemoryUsers
{
    static Dictionary<string,int> users = new();

    public static void Add(string sName)
    {
        string newUser = sName.ToUpper();

        if(!users.ContainsKey(newUser))
            users.Add(newUser, 1);
        else
            users[newUser]++;
    }

    public static void ClearAll()
    {
        users = new Dictionary<string, int>(){};
        Console.WriteLine("Successfully cleared");
    }
    public static void Remove()
    {
        Console.Write("Enter the username: ");
        string sName = Console.ReadLine();
        string user = sName.ToUpper();
        if(users.ContainsKey(user))
        {
             users.Remove(user);
             Console.WriteLine($"{sName} has been successfully deleteed");
        }
        else
            Console.WriteLine($"{sName} doesn't exist");
    }

    public static Dictionary<string,int> getUsers()
    {
        return users;
    }


}