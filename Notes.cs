// ====== This is a reference sheet for C# ======
int x;
x = 5;
Console.WriteLine(x)
// Can also write
int x = 5;
Console.WriteLine(x)
/* 
int     - Integers (whole numbers, positive and negative)
string  - Strings (a sequence of characters, including letters, numbers, or symbols)
float   - Floating point numbers (numbers that use decimals)
double  - Double precision floating point numbers (just like a float, except it takes up twice as much memory, so it can hold larger numbers or numbers with more decimal places)
bool    - Boolean variables (true or false)

Console.WriteLine("") will print, or write, a full line, including the new line. 
Console.Write("") to display the text with no newline afterward.
*/
// For input from user:
Console.Write("What is your favorite color? ");
string color = Console.ReadLine();
// Curly Braces - Used to define body of an if statement or function
if (x > y)
{
  Console.WriteLine("greater");
}
// String Interpolation
string school = "BYU-Idaho";
Console.WriteLine($"I am studying at {school}.");
