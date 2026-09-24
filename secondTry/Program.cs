Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[E]xit");
Console.WriteLine("[R]emove a TODO");

string? userChoice = Console.ReadLine(); 

if(userChoice?.Length > 10)
{
    Console.WriteLine("Long answer");
} else
{
    Console.WriteLine("Short answer");
}

// scope of local variable 
int x = 10;
{
    int y = 20;
    Console.WriteLine(x); // OK, x is visible here.
}
//Console.WriteLine(y); // Error, y is out of scope here.

// Void Methods
void PrintMessage(string message) // A void method performs an action but doesn't return a value to the caller.
{
    Console.WriteLine("The message is : " + message);
}

string? input = Console.ReadLine();
string message = string.IsNullOrEmpty(input) ? "Hello world" : input;
PrintMessage(message);

// Convert string to int using int.Parse
string value = "10";
int realValue = int.Parse(value);
Console.WriteLine("string to int value : " + realValue);

Console.WriteLine("Provide a number");
string? userInput = Console.ReadLine();

if(int.TryParse(userInput, out realValue))
{
    Console.WriteLine("Please enter a valid input");
}

Console.ReadKey();
Console.ReadLine();