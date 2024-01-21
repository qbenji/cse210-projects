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

// While Loops
string response = "yes";

while (response == "yes")
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
}

// Do-While Loops
string response;
do
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
} while (response == "yes");

// For Loops
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 2; i <= 20; i = i + 2)
{
    Console.WriteLine(i);
}

// Foreach Loops
foreach (string color in colors)
{
    Console.WriteLine(color);
}

// Random Numbers
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);

//// Lists
List<int> numbers;
List<string> words;
// The code above declares a variable to hold the list, but before you can use one, you need to create a new one to use with the new keyword.
List<int> numbers;
numbers = new List<int>();
// This is typically done on the same line:
List<int> numbers = new List<int>();
List<string> words = new List<string>();
// Notice the extra parentheses () at the end, that we use any time we create a new object.
/* One more important thing to be aware of: Any file that uses Lists (or any other standard collection), 
must refer to that library at the top of the file. (This is so common that sometimes your settings 
for C# can be specified so that you do not not have include this, but it is important to know about it, 
in case you run into problems.)
*/
using System.Collections.Generic;
/* What is "new" and why do we need it?
It turns out that List is a class or custom data type and we are creating a new object or instance of that class. 
This is actually the complete focus of this course, and beginning next week you will learn how to create your very own custom classes.
With this in mind, you will learn much more about this in coming weeks, but for now, just remember to include new before you start using a list.
*/
// Add items to list
using System.Collections.Generic;
List<string> words = new List<string>();
words.Add("phone");
words.Add("keyboard");
words.Add("mouse");
// Get list size
Console.WriteLine(words.Count);
// Iterate through list
foreach (string word in words)
{
    Console.WriteLine(word);
}
for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}