class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Asdf");
        Console.WriteLine("2. TVåååå");
        Console.WriteLine("3. Multiplyhehej");
        Console.WriteLine("4. Dividdid");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                //Add();
                break;
            case "2":
                //Subtract();
                break;
            case "3":
                //Multiply();
                break;
            case "4":
                //Divide();
                break;
            case "5":
                return;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
