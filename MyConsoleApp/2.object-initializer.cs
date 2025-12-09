using System;
using System.Reflection.Metadata.Ecma335;

namespace MyConsoleApp;

//public class object_initializer
//{
//    public string Name {get; set;}
//    public int Age {get; set;}

//    public object_initializer(string name)
//    {
//        Name = name;
//    }
//}


// INIT
public class object_initializer
{
    public string Name { get; set; }
    public int Age { get; init; }

    public object_initializer(string name, int age)
    {
        Name = name;
        Age = age;
    }
}