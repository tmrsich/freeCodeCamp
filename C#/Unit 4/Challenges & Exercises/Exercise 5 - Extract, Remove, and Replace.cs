const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";


// Want to use the substring method to get the text between the 2 span tags
const string openQ = "<span>";
const string closeQ = "</span>";

int qStart = input.IndexOf(openQ) + openQ.Length;
int qEnd = input.IndexOf(closeQ);
int qLen = qEnd - qStart;

quantity = input.Substring(qStart, qLen);
quantity = $"Quantity: {quantity}";

// Use the replace method to replace the &trade symbol with the &reg symbol
const string openO = "<h2";
const string closeO = "</span>";

int oStart = input.IndexOf(openO);
int oEnd = input.IndexOf(closeO) + closeO.Length;
int oLen = oEnd - oStart;

output = input.Substring(oStart, oLen);
output = output.Replace("&trade", "&reg");
output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);