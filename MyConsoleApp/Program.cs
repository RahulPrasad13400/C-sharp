using MyConsoleApp;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        setter_and_getter hello = new setter_and_getter();
        hello.Message = "Rahul";
        Console.WriteLine(hello.Message);
    }
}
