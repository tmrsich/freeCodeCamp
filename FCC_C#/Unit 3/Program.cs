﻿// Role playing game battle challenge
int heroHealth = 10;
int monsterHealth = 10;
Random dice = new Random();
    // Want while loop to execute when the following conditions are met:
        // Hero health is above 0
        // Monster health is above 0
do {
    int roll = dice.Next(1, 11);

    monsterHealth -= roll;
    Console.WriteLine($"The hero dealt {roll} damage, the monster now has {monsterHealth} remaining health");

    if (monsterHealth <= 0) continue;

    roll = dice.Next(1, 11);
    heroHealth -= roll;
    Console.WriteLine($"The monster dealt {roll} damage, the hero now has {heroHealth} remaining health");
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "The hero wins!" : "The monster wins!");

// // Practice with only while loops
// Random r = new Random();
// int currentNum = r.Next(1, 11);
// while (r >= 6) {
//     Console.WriteLine(currentNum);
//     currentNum = r.Next(1, 11);
// }

// // Practice with do-while loops
// Random r = new Random();
// int current = 0;
// do {
//     current = r.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// // Fizzbuzz challenge
//     // Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
//     // When the current value is divisible by 3, print the term Fizz next to the number.
//     // When the current value is divisible by 5, print the term Buzz next to the number.
//     // When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
// for (int i = 1; i <= 100; i++) {
//     if ((i % 3 == 0) && (i % 5 == 0))
//         Console.WriteLine($"{i} - FizzBuzz");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else
//         Console.WriteLine(i);
// }

// // For loop introduction & practice
// for (int i = 0; i < 10; i++) {
//     Console.WriteLine(i);
// }
// for (int i = 10; i >= 0; i--) {
//     Console.WriteLine(i);
// }
// string[] names = {"Alex", "Eddie", "David", "Michael"};
// for (int i = 0; i <= names.Length-1; i++) {
//     Console.WriteLine(names[i]);
// }

// // Switch statement practice
// // SKU = Stock Keeping Unit. 
// // SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";
// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0]) {
//     case "01": type = "Sweat shirt";
//         break;
//     case "02": type = "T-Shirt";
//         break;
//     case "03": type = "Sweat pants";
//         break;
//     default: type = "Other";
//         break;
// }

// switch (product[1]) {
//     case "BL": color = "Black";
//         break;
//     case "MN": color = "Maroon";
//         break;
//     default: color = "White";
//         break;
// } 

// switch (product[2]) {
//     case "S": size = "Small";
//         break;
//     case "M": size = "Medium";
//         break;
//     case "L": size = "Large";
//         break;
//     default: size = "One Size Fits All";
//         break;
// }
// Console.WriteLine($"Product: {size} {color} {type}");

// // Switch statement introduction
// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel) {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// // Knowledge check #2
// int value = 1;

// if (value > 0) {
//     int secondValue = 8;
//     value += secondValue;
// }
// Console.WriteLine(value);

// // Knowledge check #3 - 
// /* Will result in a build error since secondValue is outside the scope of the normal code =>
// if you were to place "firstValue += secondValue" inside the if statement block, it would build
// normally and return no errors */
// int firstValue = 5;
// if (firstValue > 5) {
//     int secondValue = 6;
// }
//     firstValue += secondValue;
// Console.WriteLine(firstValue);

// // Exercise involving variable scopes and reformatting code
// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = true;

// foreach (int number in numbers) {
//     total += number;

//     if (number == 42)
//        found = true;

// }
// if (found)
//     Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");

// // Exercise for booleans
// bool flag = true;
// if (flag) {
//     int value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// // Exercise to practice boolean expressions
// string permission = "Admin|Manager";
// int level = 55;

// if (permission.Contains("Admin")) {
//     if (level > 55) {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// } else if (permission.Contains("Manager")) {
//     if (level >= 20) {
//         Console.WriteLine("Contact an Admin for access");
//     } else {
//         Console.WriteLine("You do not have sufficient privileges");
//     }
// }

// // Exercise to flip a coin, then print the result
// int coin = new Random().Next(1, 2+1);
// Console.WriteLine((coin == 1) ? "heads" : "tails");
