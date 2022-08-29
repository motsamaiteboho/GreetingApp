public static class GreetedUser 
{
    static Dictionary<string,int> users = InMemoryUsers.getUsers();

    public static void UserCount()
    {
        Console.Write("Enter the username: ");
        string sName = Console.ReadLine().ToUpper();

        if(users.ContainsKey(sName))
            Console.WriteLine($"{sName}  has been greeted {users[sName]} times");
        else
            Console.Write($"{sName} hasn't been greeted");
    }


}