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
Console.WriteLine(y); // Error, y is out of scope here.

Console.ReadKey();
Console.ReadLine();