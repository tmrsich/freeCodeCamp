// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

bool exit = false;
do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the value returned by AverageOfEvenNumbers in the console
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("An exception has occurred");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        Console.WriteLine("Please enter a new upper bound or type 'exit' to to quit");
        string? userResponse = Console.ReadLine();
        if (userResponse.ToLower().Contains("Exit"))
        {
            exit = true;
        }
        else 
        {
            exit = false;
            upperBound = int.Parse(Console.ReadLine());
        }

    }
} while (exit == false);

// Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    if (lowerBound >= upperBound)
    {
        throw new ArgumentOutOfRangeException("upperBound", "The lower bound is higher than the upper bound, please try again.");
    }

    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}