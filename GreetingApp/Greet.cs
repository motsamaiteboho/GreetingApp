
public static class Greet
{
    public static string GreetUser(string sName, string option)
    {
        if(sName == string.Empty)
        {
         Console.Clear();
         Console.Write("Enter the username: ");
         sName =  Console.ReadLine();
        }
        
        string Languages = 
        "1. English \n"+
        "2. Sesotho \n"+
        "3. Afrikaans \n";

        string greeting = "";
        while(option !="x")
        {
            if(option == string.Empty)
            {
                Console.WriteLine(Languages);
                Console.Write("choose a language: ");
                option = Console.ReadLine();
            }
           
            switch (option)
            {
                case "1": 
                  greeting += $"Hello, {sName}";
                 option = "x";
                break;
                case "2": 
                  greeting += $"Dumelang, {sName}";
                 option = "x";
                break;
                case "3": 
                  greeting += $"Hallo, {sName}";
                 option = "x";
                break;
            }
        }
        InMemoryUsers.Add(sName);
        return greeting;
    }
}