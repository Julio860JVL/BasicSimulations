// See https://aka.ms/new-console-template for more information
List<string> options = new List<string> { "Create Account", "Login", "Go Back", "Exit" };
Console.WriteLine("Select from the following options:");

byte counter = 0;
foreach (string option in options)
{
    Console.WriteLine($"{++counter} {option}");
}

