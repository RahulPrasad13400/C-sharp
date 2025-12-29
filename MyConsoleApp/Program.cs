using MyConsoleApp;
using static MyConsoleApp.Ingredient;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // 1.setter-and-getter
        // setter_and_getter hello = new setter_and_getter();
        // hello.Message = "Rahul";
        // Console.WriteLine(hello.Message);

        // 2.object-initializer (In this name is initialized through constructor and age other wise)
        // object_initializer hello = new object_initializer("Rahul");
        // hello.Age = 24;
        // Console.WriteLine(hello.Name + " " + hello.Age);

        // INIT
        // When using init accessor, properties can only be set during object initialization or in the constructor.
        //object_initializer sample = new object_initializer("Rahul", 20);
        //Console.Write(sample.Name);
        //Console.WriteLine(sample.Age);

        // This will cause a compile-time error because Age has an init accessor
        //sample.Age = 35; 


        // Compute
        //Computed compute = new Computed(2001);
        //Console.WriteLine(compute.Age);


        // Static Methods and Classes
        //int sum = StaticMethodsAndClasses.Add(5, 10);
        //int sub = StaticMethodsAndClasses.Sub(10, 5);

        //var hello = new StaticMethodsAndClasses();
        //hello.Hello();  

        //new StaticMethodsAndClasses();

        //Console.WriteLine(sum);
        //Console.WriteLine(sub);

        //Console.WriteLine("count of instance : " + StaticMethodsAndClasses.countInstanceOfClass);
        //Console.ReadKey();


        //GuessingGame random = new GuessingGame(new Dice());
        //GameResult result = random.Play();
        //Console.WriteLine("007 random : "+ result);

        Pizza pizza = new Pizza();
        Cheddar cheddar = new Cheddar();
        Console.WriteLine(cheddar.PublicMethod());
        // you cannot access the private method from here
    }
}
    