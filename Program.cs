class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Avsluta");
        Console.Write("Ange val: ");
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
                Console.WriteLine("felaktigt val");
                break;
        }
    }
}