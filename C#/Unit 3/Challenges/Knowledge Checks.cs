// Knowledge check #2
int value = 1;

if (value > 0) {
    int secondValue = 8;
    value += secondValue;
}
Console.WriteLine(value);

// Knowledge check #3 - 
/* Will result in a build error since secondValue is outside the scope of the normal code =>
if you were to place "firstValue += secondValue" inside the if statement block, it would build
normally and return no errors */
int firstValue = 5;
if (firstValue > 5) {
    int secondValue = 6;
}
    firstValue += secondValue;
Console.WriteLine(firstValue);