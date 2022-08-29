namespace GreetingApp;
class Program
{
    static Dictionary<string, int> users = new();

    static void Main(string[] args)
    {
        
        string selection = "";
        string menu = 
            "1. Great user\n"+
            "2. Greeted users \n" +
            "3. Greeted user \n" +
            "4. Counter \n" +
            "5. Clear all \n" +
            "6. Delete user \n" +
            "7. help \n" +
            "x. exit";

        do
        {
            Console.WriteLine("GREETING APP");
            Console.WriteLine("===================================");
            Console.WriteLine(menu);
            Console.Write("select an option: ");
            selection  = Console.ReadLine();

            switch (selection)
            {
                case "1": 
                Greet greet = new Greet(users);
                greet.GreetUser();
                break;
                case "2":
                GreetedUsers greetedUsers = new GreetedUsers(users);
                greetedUsers.GetGreetedUsers();
                break;
            }
        }
        while(selection != "x");

        Console.WriteLine("Thank you for using our greeting app, press any key to exit..");
        Console.ReadKey();
    }
 
}
