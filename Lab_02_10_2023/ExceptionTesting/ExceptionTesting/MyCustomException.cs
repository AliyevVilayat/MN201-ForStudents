namespace ExceptionTesting;

public class MyCustomException:Exception
{

    public MyCustomException() : base("Custom Message")
    {

    }

    public MyCustomException(string message) : base(message)
    {

    }
}
