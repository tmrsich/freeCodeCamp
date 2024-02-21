string pangram = "The quick brown fox jumps over the lazy dog";

// Makes the string into an array, with each word as an element, write it to a new string that is the length of the newPangram string
string[] newPangram = pangram.Split(" ");
string[] final = new string[newPangram.Length];

// Iterates through the newPangram string length, writing each word to a char array, reversing the letters, then appending it to the string whose length is the size of the split newPangram string 
for (int i = 0; i < newPangram.Length; i++) {
    char[] letters = newPangram[i].ToCharArray();
    Array.Reverse(letters);
    final[i] = new string(letters);
}

string finalResults = String.Join(" ", final);

Console.WriteLine(finalResults);