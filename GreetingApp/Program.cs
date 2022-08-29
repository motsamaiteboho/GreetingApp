namespace GreetingApp;
class Program
{
   

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
            Console.WriteLine("\n");
            Console.WriteLine("GREETING APP");
            Console.WriteLine("===================================");
            Console.WriteLine(menu);
            Console.Write("select an option: ");
            selection  = Console.ReadLine();

            switch (selection)
            {
                case "1": 
                Greet.GreetUser();
                break;
                case "2":
                GreetedUsers.GetGreetedUsers();
                break;
                case "3":
                GreetedUser.UserCount();
                break;
                case "4":
                Counter.getCount();
                break;
                case "5":
                InMemoryUsers.ClearAll();
                break;
                case "6":
                InMemoryUsers.Remove();
                break;
                case "7":
                 Console.WriteLine("Here are the valid options: 1 , 2, 3 ,4 , 5, 6, 7");
                 Console.WriteLine("option x to exit the appliction");
                break;
            }
        }
        while(selection != "x");

        Console.WriteLine("Thank you for using our greeting app, press any key to exit..");
        Console.ReadKey();
    }
 
}
