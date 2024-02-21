// Array practice
string[] arr = {
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};

foreach (string id in arr) {
    if (id.StartsWith("B")) {
        Console.WriteLine(id);
    }
}

// One way of creating a new array
int[] newArr = new int[3];
newArr[0] = 5;
newArr[1] = 6;
newArr[2] = 7;

// Simplified way (common) way of creating a new array
int[] newArr2 = [5, 6, 7];