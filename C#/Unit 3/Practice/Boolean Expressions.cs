// Exercise for booleans
bool flag = true;
if (flag) {
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

// Exercise to practice boolean expressions
string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin")) {
    if (level > 55) {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else {
        Console.WriteLine("Welcome, Admin user.");
    }
} else if (permission.Contains("Manager")) {
    if (level >= 20) {
        Console.WriteLine("Contact an Admin for access");
    } else {
        Console.WriteLine("You do not have sufficient privileges");
    }
}

// Exercise to flip a coin, then print the result
int coin = new Random().Next(1, 2+1);
Console.WriteLine((coin == 1) ? "heads" : "tails");
