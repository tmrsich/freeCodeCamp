public class Operations
{
    // Quick method that takes user input from the console and clears the console after
    public static void confirmChoice()
    {
        Console.ReadLine();
        Console.Clear();
    }


    /* 
    Broader method that, based on whether or not arithmetic is toggled on or not runs
    the calculator for either the nth term in an arithmetic or geometric sequence
    */
    public static void CalculateArithmeticNthTerm()
    {
        // Takes user inputs then solves for the nth term in an arithmetic sequence
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

    public static void CalculateGeometricNthTerm()
    {
        // Takes user inputs then solves for the nth term in a geometric sequence
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

    /* 
    Broader method that, based on whether or not sumArithmetic is toggled on or not runs
    the calculator for either the sum of an arithmetic or geometric sequence
    */
    public static void CalculateArithmeticSumSeries()
    {
        // Takes user inputs then solves for the sum of an arithmetic sequence
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

        aSubn = aSub1 + (n - 1) * d;

        Ssubn = n * ((aSub1 + aSubn) / 2);
        Console.WriteLine($"The sum of your arithmetic sequence is {Ssubn}");
        Console.ReadLine();
    }
}