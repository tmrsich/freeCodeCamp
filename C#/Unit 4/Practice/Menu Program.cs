// Initialization of variables to be used later
#pragma warning disable CS0168 // Variable is declared but never used
string? result;
#pragma warning restore CS0168 // Variable is declared but never used
string? menuSelect = "";

do {
    Console.Clear();
    Console.WriteLine("Hello, please select an option from the list.\n");

    // Gives menu options
    Console.WriteLine("A. Question #1");
    Console.WriteLine("B. Question #2");
    Console.WriteLine("C. Question #3");
    Console.WriteLine("D. Question #4");
    Console.WriteLine("Exit");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
    menuSelect = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    switch (menuSelect) {
        case "a":
            Console.WriteLine("You have selected option A.");
            Console.WriteLine("\n\rPlease press the enter key to continue");
            Console.ReadLine();
            break;
        case "b":
            Console.WriteLine("You have selected option B.");
            Console.WriteLine("\n\rPlease press the enter key to continue");
            Console.ReadLine();
            break;
        case "c":
            Console.WriteLine("You have selected option C.");
            Console.WriteLine("\n\rPlease press the enter key to continue");
            Console.ReadLine();
            break;
        case "d":
            Console.WriteLine("You have selected option D.");
            Console.WriteLine("\n\rPlease press the enter key to continue");
            Console.ReadLine();
            break;
        default:
            if (menuSelect.ToLower() != "exit") {
                Console.WriteLine("You did not select a valid option, please select a valid option");
            }
            Console.WriteLine("\n\rPlease press the enter key to choose again from the menu");
            break;
    }
} while (menuSelect.ToLower() != "exit");
