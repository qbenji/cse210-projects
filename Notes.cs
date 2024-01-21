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

//// IFS
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

//// Converting Variable Types
string valueInText = "42";
int number = int.Parse(valueInText);

Console.Write("What is your favorite number? ");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);

int number = 42;
string textVersion = number.ToString();
//// Loops
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

//// Random Numbers
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

//// Functions
// Structure
returnType FunctionName(dataType parameter1, dataType parameter2)
{
    // function_body
}
// Void - no parameters
void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}
// Single string parameter
void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}
// Two int parameter
int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}

//// Functions vs Methods
/* From previous courses, you may recall a distinction between standalone functions and member functions, which are called methods. 
Methods play a very important role in Programming with Classes and they will be discussed at length in the coming lessons.
In C#, because the language is so dedicated to the principles of Programming with Classes, the default case for all functions is to be methods,
which must be called in the context of an object. (Again, more on this later!) But this has an important ramification for you now.
If you want to define "regular" standalone function, you need to use the static keyword. This tells C# that you want your functions 
to be able to be called without any other context.
*/
// Standalone Function
static void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}

static void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}

static int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}
/* Until we start writing classes, you should put the static keyword in front of all your functions. 
Use static for all of your functions until we start writing classes.
*/

