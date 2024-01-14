// ====== This is a reference sheet for C# ======

/* Variable Types & Notes
int     - Integers (whole numbers, positive and negative)
string  - Strings (a sequence of characters, including letters, numbers, or symbols)
float   - Floating point numbers (numbers that use decimals)
double  - Double precision floating point numbers (just like a float, except it takes up twice as much memory, so it can hold larger numbers or numbers with more decimal places)
bool    - Boolean variables (true or false)

Console.WriteLine("") will print, or write, a full line, including the new line. 
Console.Write("") to display the text with no newline afterward.
*/

/* Operators
==, !=, >=, <= - Comparison Operators
&&  - AND
||  - OR
!   - NOT [Ex: if (!(name == "Peter" || name == "James" || name == "John"))]

*/

/* Common Practice
    * The naming convention for variables is to use "camel case."
    * Tab over the body of logical statements
*/

int x;
x = 5;
Console.WriteLine(x)
// Can also write
int x = 5;
Console.WriteLine(x)

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

// Nested IF
if (x > y)
{
    if (x > z)
    {
        Console.WriteLine("greater than both");
    }
}

// IF . ELSE IF . ELSE
if (x > y)
{
    Console.WriteLine("greater than y");
}
else if (x > z)
{
    Console.WriteLine("greater than z");
}
else
{
    Console.WriteLine("less than both");
}

// Converting Variable Types
string valueInText = "42";
int number = int.Parse(valueInText);

Console.Write("What is your favorite number? ");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);

int number = 42;
string textVersion = number.ToString();