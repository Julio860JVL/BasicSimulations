// See https://aka.ms/new-console-template for more information
using LoginSystem.OptionsToSelect;

internal class Program
{
    public static void Main(string[] args)
    {
        string morningOrAfternoon;
        if (DateTime.Now.Hour <= 11)
        {
            morningOrAfternoon = "morning";
        }
        else
        {
            morningOrAfternoon = "afternoon";
        }

        Console.WriteLine($"\nGood {morningOrAfternoon} welcome to the Login System.\n" +
            "Select from the following options:");

        List<string> options = new List<string> { "Create Account", "Login", "Go Back", "Exit" };

        byte counter = 0;
        foreach (string option in options)
        {
            Console.WriteLine($"{++counter} {option}");
        }

        string selection = Console.ReadLine();
        switch (selection)
        {
            case "1":
                AccountCreation.CreateAccount();
                break;
            case "2":
                //Console.WriteLine("Login");
                break;
            case "3":
                //Console.WriteLine("Go Back");
                break;
            case "4":
                Console.WriteLine("Good bye!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                Main(new string[] { });
                break;
        }
    }
}
