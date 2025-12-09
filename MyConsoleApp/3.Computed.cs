using System;

namespace MyConsoleApp;


//A computed property is a property whose value is calculated instead of stored.
public class Computed
{
    public int BirthYear { get; private set; }
    public int Age
    {
        get
        {
            return DateTime.Now.Year - BirthYear;
        }
    }

    public Computed(int value)
    {
        BirthYear = value;
    }
}
