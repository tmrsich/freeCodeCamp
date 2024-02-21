// Practice with only while loops
Random r = new Random();
int currentNum = r.Next(1, 11);
while (r >= 6) {
    Console.WriteLine(currentNum);
    currentNum = r.Next(1, 11);
}

// Practice with do-while loops
Random r = new Random();
int current = 0;
do {
    current = r.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

// For loop introduction & practice
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}
for (int i = 10; i >= 0; i--) {
    Console.WriteLine(i);
}
string[] names = {"Alex", "Eddie", "David", "Michael"};
for (int i = 0; i <= names.Length-1; i++) {
    Console.WriteLine(names[i]);
}