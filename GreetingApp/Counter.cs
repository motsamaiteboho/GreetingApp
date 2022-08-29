public static class Counter 
{
    static Dictionary<string,int> users = InMemoryUsers.getUsers();

    public static void getCount()
    {
        int count = users.Values.Count;
        Console.WriteLine($"The number of users is  {count}");
    }
}