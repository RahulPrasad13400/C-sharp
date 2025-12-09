using System;

namespace MyConsoleApp;


// Static class can only contain static members
// eg public static class StaticMethodsAndClasses

public class StaticMethodsAndClasses
{
	public static int Add(int a, int b) => a + b;
	public static int Sub(int a, int b) => a - b;
	public static int Mul(int a, int b) => a * b;
	public static int Div(int a, int b) => a / b;

	public static int countInstanceOfClass { get; set; }

	public void Hello()
	{
		Console.WriteLine("Hello from Static Method");
	}

	public StaticMethodsAndClasses()
	{
		countInstanceOfClass++;
	}
}
