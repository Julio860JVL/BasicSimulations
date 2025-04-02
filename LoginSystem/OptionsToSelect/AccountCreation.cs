namespace LoginSystem.OptionsToSelect
{
    public class AccountCreation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // I am aware that this is not secure, but this is a simple example.
        public string AccountNumber { get; set; }

        public AccountCreation(string firstName, string lastName, string email, string password, string accountNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            AccountNumber = accountNumber;
        }

        public static void CreateAccount()
        {
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter account number:");
            string accountNumber = Console.ReadLine() ?? string.Empty;

            AccountCreation account = new AccountCreation(firstName, lastName, email, password, accountNumber);
            Console.WriteLine("Account created successfully!");
            Program.Main(new string[] { });
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Account Number: {AccountNumber}");
        }
    }

}
