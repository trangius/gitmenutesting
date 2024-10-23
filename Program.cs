class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                //Add();
                break;
            case 2:
                //Subtract();
                break;
            case 3:
                //Multiply();
                break;
            case 4:
                //Divide();
                break;
            case 5:
                return;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}