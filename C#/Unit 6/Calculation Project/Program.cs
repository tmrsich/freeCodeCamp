public class Program
{
    public static void Main(string[] args)
    {
        // Application that calculates basic financial information / math; Declaration/Initialization of variables
        string? readResult = "";
        string menu = "";
        do
        {
            Console.Clear();
            Console.WriteLine("Hello, please select an option from the menu, or type 'exit' to exit");
            Console.WriteLine("1. Calculate simple interest");
            Console.WriteLine("2. Calculate compound interest");
            Console.WriteLine("3. Calculate the nth term of an arithmetic sequence");
            Console.WriteLine("4. Calculate the nth term of a geometric sequence");
            Console.WriteLine("5. Calculate the sum of an arithmetic sequence");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                menu = readResult.ToLower();
            }

            // Use switch statement to process option selected
            switch (menu)
            {
                case "1":
                    Console.WriteLine("\nYou have selected option 1: Calculate simple interest. Press enter to continue.");
                    Operations.confirmChoice();
                    break;
                case "2":
                    Console.WriteLine("\nYou have selected option 2: Calculate compound interest. Press enter to continue.");
                    Operations.confirmChoice();
                    break;
                case "3":
                    Console.WriteLine("\nYou have selected option 3: Calculate the nth term of an arithmetic sequence. Press enter to continue");
                    Operations.confirmChoice();
                    Operations.CalculateArithmeticNthTerm();
                    break;
                case "4":
                    Console.WriteLine("\nYou have selected option 4: Calculate the nth term of a geometric sequence. Press enter to continue");
                    Operations.confirmChoice();
                    Operations.CalculateGeometricNthTerm();
                    break;
                case "5":
                    Console.WriteLine("\nYou have selected option 5: Calculate the sum of an arithmetic sequence. Press enter to continue");
                    Operations.confirmChoice();
                    Operations.CalculateArithmeticSumSeries();
                    break;
                default:
                    if (menu.ToLower() != "exit")
                    {
                        Console.WriteLine("\nYou have selected an invalid option. Please select a valid option from the menu to continue.");
                        Operations.confirmChoice();
                    }
                    break;
            }
        } while (menu != "exit");
    }
}