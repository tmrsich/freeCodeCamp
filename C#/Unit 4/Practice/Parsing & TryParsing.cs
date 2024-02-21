// Practice with parsing/TryParse
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Knowledge Check
string myInput = "2.71828";
decimal myInputDecimal;
decimal.TryParse(myInput, out myInputDecimal);
Console.WriteLine(myInputDecimal);
Console.WriteLine(myInputDecimal.GetType());