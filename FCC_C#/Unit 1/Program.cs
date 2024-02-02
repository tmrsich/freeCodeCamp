Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
string finalMessage = "";

// Series of conditions that alters the final message variable
if (daysUntilExpiration == 0) {
    finalMessage = "Your subscription has expired";
}
else if (daysUntilExpiration == 1) {
    discountPercentage = 20;
    finalMessage = $"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!";
}
else if (daysUntilExpiration <= 5) {
    discountPercentage = 10;
    finalMessage = $"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}!";
}
else if (daysUntilExpiration <= 10) {
    finalMessage = "Your subscription will expire soon. Renew now!";
}

// Console.WriteLine statement that just prints out the final message which depends on the number of days left until the subscription expires.
Console.WriteLine(finalMessage);