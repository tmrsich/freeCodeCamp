string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
decimal total = 0;
foreach (string val in values) {
    decimal num;
    if (decimal.TryParse(val, out num)) {
        total += num;
    } else {
        message += val;
    }
}
Console.WriteLine($"Message: {message}\nTotal: {total}");