double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}

// Return numbers from methods
double usd = 23.73;
int vnd = UsdToVnd(usd);
Console.WriteLine($"${usd} USD = ${vnd} VND");

vnd = 557655;
usd = VndToUsd(vnd);
Console.WriteLine($"${vnd} VND = ${usd} USD");

int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int)(rate * usd);
}

double VndToUsd(double vnd)
{
    int rate = 23500;
    return vnd / rate;
}

// Method that returns a string
string input = "snake";
Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

// A string is technically an "array" of characters, with each element representing a character, which is why this works
string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length-1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

// Method to reverse words in a sentence
string input = "This is a test sentence.";
Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));


string ReverseSentence(string input) 
{
    string result = "";

    // An array of words, where it splits each element such that it represents a word in the sentence
    string[] words = input.Split(" ");
    
    // Want to iterate through all the words in the sentence, then iterate through all the letters in the sentence
    // Can also use a foreach loop that iterates through each element in the array, and each operation is performed on that element
    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

// A string is technically an "array" of characters, with each element representing a character, which is why this works
string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length-1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

// Return booleans from methods
bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end) 
    {
        if (word[start] != word[end]) 
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}

// Return arrays from methods
int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

// If no coins match, the return statement at the bottom will change 
if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

Console.WriteLine(result.GetLength(0));

int[,] TwoCoins(int[] coins, int target) 
{
    /*
        Initially set to -1 to ensure that it does not accidentally indicate an index position of a positive number,
        which could signal a false positive in the coins whose sum is the target value, but in the end it doesn't even matter
    
        Result is initialized to 5 elements because we want to find a MAXIMUM of 5 pairs, 
        thus the length of result will always be 5, regardless of the pairs that actually match
    */
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    // Iterates through all the coins in the coins array
    /* 
        Essentially, it will start at index 0 then iterate through all the other coins in the array to find one that makes the condition of the
        current coin + the next available coin that adds up to the target value, currently initialized at 30.
    */
    for (int curr = 0; curr < coins.Length; curr++) 
    {
        // Iterates through all the "next" coins, or the coins in the index position of curr + 1
        for (int next = curr + 1; next < coins.Length; next++) 
        {
            // If the condition is met, and the current coin + the next = target, initial result[count, 0] = curr (curr is initialized at 0) will change the -1 to a 0
            // Additionally when this condition is met, result[count, 1] = next is result[0, 1] = next, which sets the -1 to the index position of the coin that matches
            // If the condition is not met, it will check to see if it has reached the end of the array in order to avoid an array out of bounds exception
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }

            /*
                If the count is equal to the length of the result, it returns the "result" array
                which contains the list of indices of coins that add together to sum up to the target value
            */
            // If the count makes it to "5" which is the length of the results array (5 elements) then it will return that array, because we only want a maximum of 5 matches
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    /* 
        If the count is 0 then it will return a new integer array of [0, 0], indicating that no coin pairs that add up to the target value have been found;
        If this condition is false, it will just return the result
    */
    return (count == 0) ? new int[0,0] : result;
}

/*
MINI CHALLENGE PROJECT - Update the methods so that it matches the output similar to that of freeCodeCamp
*/
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

// Changes method type from void to bool that contains a ternary operator that returns true if the user input when converted to lowercase is "y"
bool ShouldPlay()
{
    return (Console.ReadLine().ToLower() == "y" || (Console.ReadLine() == "\n")) ? true : false;
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 6);

        Console.WriteLine($"\nRoll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose());
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();

        string WinOrLose()
        {
            return (roll > target) ? "You won!" : "You lost!";
        }
    }
}

/* NOTES:
    - Contoso Petting Zoo has 18 different species of animals
    - Visiting students are assigned to groups, each group has an animal assigned to it
        - School A has 6 vistiing groups (the default number)
        - School B has 3 visiting groups
        - School C has 2 visiting groups
    - For each visiting school:
        - Randomize the animals
        - Assign the animals to the correct number of groups
        - Print the school name
        - Print the animal groups
*/

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A: ");
PlanSchoolVisit("School B: ", 3);
PlanSchoolVisit("School C: ", 2);

void PlanSchoolVisit(string schoolName, int groups = 6) 
{
    RandomizeAnimals(); 
    string[,] group1 = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group1);
}

/*
    Method that randomizes the animals, or the elements in the pettingZoo array
    This method cycles through the array utilizing a for loop that selects a random index and swaps it with the current element
    In the case of the first iteration where i = 0 and r (which generates in this case a random number between 0 and 17 inclusive let's say 10)
    The method does the following:
        - Stores the value of pettingZoo[0] ("alpacas") to the string temp
        - Overrides the value of pettingZoo[0] (the first element in the array) to be the value of pettingZoo[10] ("llamas")
        - Sets the value of pettingZoo[10] (which was "alpacas") to the value stored in the temp string ("alpacas")
    Overall the method takes the string value of an initial index position in the array, and swaps it with the position of another index position, which is randomized
*/
void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        /* 
            Setting the lower bound to "i" ensures that the distribution of randomly selected elements to 
            be swapped is improved by updates the range as the for loop moves through the array
        */
        int r = random.Next(i, pettingZoo.Length);
        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}

// Method that returns a 2D array with an optional parameter
string[,] AssignGroup(int groups = 6)
{
    /*
        Creates a 2D array called "result" that sets its first dimension (groups) to 6 and the 2nd dimension
        (number of animals each group will have) to the value of the length of the pettingZoo array divided by the number of groups
    */
    string[,] result = new string[groups, pettingZoo.Length/groups];
    
    // The int start variable represents the "starting" index position of the pettingZoo array
    int start = 0;

    // The first loop cycles through each group, while the inner for loop cycles through each animal the group will have
    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            /* 
                Ex: When i = 0 and j = 0, this means that the first element of the array in the 
                first nested array will be set equal to pettingZoo[0] before incrementing its value by 1
            */
            result[i, j] = pettingZoo[start++];
        }
    }
    return result;
}

// Method that displays the results
void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i+1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]} ");
        }
        Console.WriteLine();
    }
}