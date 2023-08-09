using System;

class Program
{
    static void Main()
    {
        // Sample data
        string[] names = { "John", "Jane", "Michael", "Emily" };
        string[] surnames = { "Doe", "Smith", "Johnson", "Williams" };
        string[] fatherNames = { "Robert", "William", "David", "Christopher" };
        string[] emails = { "john.doe@example.com", "jane.smith@example.com", "michael.johnson@example.com", "emily.williams@example.com" };
        string[] usernames = { "johndoe123", "janesmith456", "mjohnson", "emilyw" };

        // Header
        Console.WriteLine("┌─────────────┬─────────────┬─────────────┬───────────────────────────-─┬───────────────┐");
        Console.WriteLine("│    Name     │   Surname   │ Father Name │            Email            │    Username   │");
        Console.WriteLine("├─────────────┼─────────────┼─────────────┼─────────────────────────────┼───────────────┤");

        // List of information
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"│ {names[i],-11} │ {surnames[i],-11} │ {fatherNames[i],-11} │ {emails[i],-27} │ {usernames[i],-13} │");
            if (i < names.Length - 1)
            {
                Console.WriteLine("├─────────────┼─────────────┼─────────────┼─────────────────────────────┼───────────────┤");
            }
        }

        // Footer
        Console.WriteLine("└─────────────┴─────────────┴─────────────┴─────────────────────────────┴───────────────┘");
    }
}
