// Role playing game battle challenge
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