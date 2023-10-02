using ExceptionTesting;

try
{
    Group group = new("MN201", 1);
    //Console.WriteLine(group.GroupId);

    Student student = group[15];
    if (student is null)
    {
        Student newSstudent = new("AZE1", "Elcin", "Asadov");
        group[0] = newSstudent;
    }

    Console.WriteLine(group[0]);
}
catch(MyCustomException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine("Bu index out of range exceptiondir.");
    Console.WriteLine(ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException.Message);
    if(ex.InnerException is IndexOutOfRangeException)
    {

    }
}
