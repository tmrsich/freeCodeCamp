





















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