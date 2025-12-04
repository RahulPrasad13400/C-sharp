using System;

namespace MyConsoleApp;

public class setter_and_getter
{
    private string _message;
    public string Message
    {
        get
        {
            return _message;
        }
        set
        {
            if (value != "hello")
            {
                _message = value;
            }
        }
    }
}
