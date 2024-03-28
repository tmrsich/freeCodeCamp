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