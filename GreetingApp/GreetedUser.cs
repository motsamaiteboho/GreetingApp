public static class GreetedUser 
{
    static Dictionary<string,int> users = InMemoryUsers.getUsers();

    public static string UserCount(string sName)
    {
        string sResult = string.Empty;
        if(sName == string.Empty)
        {
            Console.Write("Enter the username: ");
            sName = Console.ReadLine().ToUpper().Trim();
        }
        
        if(users.ContainsKey(sName))
             sResult += $"{sName}  has been greeted {users[sName]} times";
        else
             sResult += $"{sName} hasn't been greeted";
        return sResult;
    }


}