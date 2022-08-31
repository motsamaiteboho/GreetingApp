public static class Counter 
{
    static Dictionary<string,int> users = InMemoryUsers.getUsers();

    public static string getCount()
    {
        string  sResults = string.Empty;
        int count = users.Values.Count;
        sResults += $"The number of users is  {count}";
        return sResults;
    }
}