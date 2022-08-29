
public class Greet
{
    Dictionary<string,int> users;
    public Greet(Dictionary<string,int> users)
    {
        this.users = users;
    }
    public void GreetUser()
    {
        Console.Clear();
        Console.Write("Enter the username: ");
        string sName =  Console.ReadLine();

        string option = string.Empty;
        string Languages = 
        "1. English \n"+
        "2. Sesotho \n"+
        "3. Afrikaans \n";

        while(option !="x")
        {
            Console.WriteLine(Languages);
            Console.Write("choose a language: ");
            option = Console.ReadLine();
            switch (option)
            {
                case "1": 
                 Console.WriteLine($"Hello, {sName}");
                 option = "x";
                break;
                case "2": 
                 Console.WriteLine($"Dumelang, {sName}");
                 option = "x";
                break;
                case "3": 
                 Console.WriteLine($"Hallo, {sName}");
                 option = "x";
                break;
            }
        }

        if(!users.ContainsKey(sName))
            users.Add(sName, 1);
        else
            users[sName]++;
    }

    public Dictionary<string,int> newUsers()
    {
        return users;
    }

}