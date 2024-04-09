// Simple program that takes the movements from Vivaldi's "Four Seasons" in an array and prints them, using a foreach and for/nested for loop to print each movement out respectively 
string[,] vivaldi = 
{
    {"spring 1", "spring 2", "spring 3"},
    {"summer 1", "summer 2", "summer 3"},
    {"autumn 1", "autumn 2", "autumn 3"},
    {"winter 1", "winter 2", "winter 3"}
};

foreach (string movement in vivaldi)
{
    Console.WriteLine(movement);
}

for (int i = 0; i < vivaldi.GetLength(0); i++)
{
    for (int j = 0; j < vivaldi.GetLength(1); j++)
    {
        Console.WriteLine(vivaldi[i, j]);
    }
}