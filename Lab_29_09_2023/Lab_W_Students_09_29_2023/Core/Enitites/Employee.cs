using System.Diagnostics.Metrics;

namespace Core.Enitites;

public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public static int counter = 1;

    public Employee(string name, string surname, int age)
    {

        Name = name;
        Surname = surname;
        Age = age;
        Id = counter++;

    }

    public abstract double CalculateSalary();
    public abstract void DisplayDetails();

}
