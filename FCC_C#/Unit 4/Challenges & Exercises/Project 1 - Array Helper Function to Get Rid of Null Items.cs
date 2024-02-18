// Initialized a variable to later be used/modified inside of a foreach loop, to then be printed outside of the loop
int notNully = 0;
string[] examples = {"B14", "B15", "B16"};

// Array method to delete an item inside of the array at index position 0 (the first item) with a length of 1 (starting at index position 0 and spanning 1 item, effectively deleting the first item)
Array.Clear(examples, 0, 1);

// Foreach loop to iterate through all the items in teh array and to print them out - If the item is "null", which in this case means "removed" or cleared from the array, then it will increase a counter
foreach (string example in examples) {
    if (example != null) {
        notNully++;
    }
}

// Prints out the counter of all the non-null items in the array
Console.WriteLine(notNully);

// Our next step is to create a second array the size of the counter variable - Which counted all non-null items in the array
string[] improvedExamples = new string[notNully];
int currentIndex = 0;

// Now for the final step we can loop through the original array and copy non-null values into the new array by stating that the index position in the improvedExamples arrays is equal to a non-null item in the original examples array 
for (int i = 0; i < examples.Length; i++) {
    if (examples[i] != null) {
        improvedExamples[currentIndex] = examples[i];
        currentIndex++;
    }
}

// Printing the new array
foreach (string newExample in improvedExamples) {
    Console.WriteLine(newExample);
}