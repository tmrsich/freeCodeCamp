public class Operations
{
    // Declarations/Initializations
    static double aSub1;
    static double aSubn;
    static double Ssubn;
    static int n;

    // Arithmetic specific
    static double d;

    // Geometric specific
    static double r;

    // Quick method that takes user input from the console and clears the console after
    public static void confirmChoice()
    {
        Console.ReadLine();
        Console.Clear();
    }

    // Method to solve for the nth term in an arithmetic sequence
    public static void CalculateArithmeticNthTerm()
    {
        // Takes user inputs
        Console.WriteLine("Please input the value for the first term in the arithmetic sequence:");
        aSub1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please input the value for the nth term that you want to solve for:");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input the value for the common difference:");
        d = Convert.ToInt32(Console.ReadLine());

        aSubn = aSub1 + (n - 1) * d;
        Console.WriteLine($"Term {n} in the arithmetic sequence is {aSubn}");
        Console.ReadLine();
    }

    // Method to solve for the nth term in a geometric sequence
    public static void CalculateGeometricNthTerm()
    {
        Console.WriteLine("Please input the value for the first term in the geometric sequence:");
        aSub1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please input the value for the nth term that you want to solve for:");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input the value for the common ratio:");
        r = Convert.ToDouble(Console.ReadLine());

        double aSubn = aSub1 * Math.Pow(r, (n - 1));
        Console.WriteLine($"Term {n} in the geometric sequence is {aSubn}");
        Console.ReadLine();
    }

    // Method to solve for the sum of an arithmetic sequence
    public static void CalculateArithmeticSumSeries()
    {
        Console.WriteLine("Please input the value for the first term in the arithmetic sequence:");
        aSub1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please input the value for the nth term that you want to solve for:");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input the value for the common difference:");
        d = Convert.ToInt32(Console.ReadLine());

        aSubn = aSub1 + (n - 1) * d;

        Ssubn = n * ((aSub1 + aSubn) / 2);
        Console.WriteLine($"The sum of your arithmetic sequence is {Ssubn}");
        Console.ReadLine();
    }

    // Method to solve for the sum of a geometric sequence
    public static void CalculateGeometricSumSeries()
    {
        Console.WriteLine("Please input the value for the first term in the geometric sequence");
        aSub1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please input the value for the nth term that you want to solve for:");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input the value for the common difference:");
        d = Convert.ToInt32(Console.ReadLine());

        aSubn = aSub1 + (n - 1) * d;

        Ssubn = aSub1 * (1 - Math.Pow(r, n))/(1-r);
        Console.WriteLine($"The sum of your geometric sequence is {Ssubn}");
    }
}
