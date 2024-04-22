// Application that calculates basic financial information / math; Declaration/Initialization of variables
string? readResult = "";
string menu = "";
bool arithmetic;
do 
{
    Console.Clear();
    Console.WriteLine("Hello, please select an option from the menu, or type 'exit' to exit");
    Console.WriteLine("1. Calculate simple interest");
    Console.WriteLine("2. Calculate compound interest");
    Console.WriteLine("3. Calculate the nth term of an arithmetic sequence");
    Console.WriteLine("4. Calculate the nth term of a geometric sequence");
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
            confirmChoice();
            break;
        case "2":
            Console.WriteLine("\nYou have selected option 2: Calculate compound interest. Press enter to continue.");
            confirmChoice();
            break;
        case "3":
            Console.WriteLine("\nYou have selected option 3: Calculate the nth term of an arithmetic sequence. Press enter to continue");
            arithmetic = true;
            confirmChoice();
            CalculateNthTerm();
            break;
        case "4":
            Console.WriteLine("\nYou have selected option 4: Calculate the nth term of a geometric sequence. Press enter to continue");
            arithmetic = false;
            confirmChoice();
            CalculateNthTerm();
            break;
        default: 
            if (menu.ToLower() != "exit")
            {
                Console.WriteLine("\nYou have selected an invalid option. Please select a valid option from the menu to continue.");
                confirmChoice();
            }
            break;
    }
} while (menu != "exit");

        // Quick method that takes user input from the console and clears the console after
        void confirmChoice()
        {
            Console.ReadLine();
            Console.Clear();
        }

        /* 
        Broader method that, based on whether or not arithmetic is toggled on or not runs
        the calculator for either the nth term in an arithmetic or geometric sequence
        */
        void CalculateNthTerm()
        {
            // Takes user inputs then solves for the nth term in an arithmetic sequence
            if (arithmetic)
            {
                double aSub1;
                int n;
                int d;

                Console.WriteLine("Please input the value for the first term in the arithmetic sequence:");
                aSub1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please input the value for the nth term that you want to solve for:");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please input the value for the common difference:");
                d = Convert.ToInt32(Console.ReadLine());

                double nthTerm = aSub1 + (n - 1) * d;
                Console.WriteLine($"Term {n} in the arithmetic sequence is {nthTerm}");
                Console.ReadLine();
            }
            // Takes user inputs then solves for the nth term in a geometric sequence
            else
            {
                double aSub1;
                int n;
                double r;

                Console.WriteLine("Please input the value for the first term in the geometric sequence:");
                aSub1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please input the value for the nth term that you want to solve for:");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please input the value for the common ratio:");
                r = Convert.ToDouble(Console.ReadLine());

                double nthTerm = aSub1 * Math.Pow(r, (n - 1));
                Console.WriteLine($"Term {n} in the geometric sequence is {nthTerm}");
                Console.ReadLine();
            }
        }
    }
}

/* 
Broader method that, based on whether or not sumArithmetic is toggled on or not runs
the calculator for either the sum of an arithmetic or geometric sequence
*/
void CalculateSumSeries()
{
    // Takes user inputs then solves for the sum of an arithmetic sequence
    if (sumArithmetic)
    {
        double Ssubn;
        double aSub1;
        double aSubn;
        int n;
        int d;

        Console.WriteLine("Please input the value for the first term in the arithmetic sequence");
        aSub1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please input the value for the nth term that you want to solve for:");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input the value for the common difference:");
        d = Convert.ToInt32(Console.ReadLine());

        aSubn = aSub1 + (n-1) * d;

        Ssubn = n * ((aSub1 + aSubn)/2);
        Console.WriteLine($"The sum of your arithmetic sequence is {Ssubn}");
        Console.ReadLine();
    }
}