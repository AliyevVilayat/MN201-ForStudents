namespace EmployeProject.Core.Entities;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }

    private static int _idCounter =1;

    public Employee( string name,string surname, string email)
    {
        Id = _idCounter;
        Name = name;
        Surname = surname;
        Email = email;

        _idCounter++;
         
    }

    public override string ToString()
    {
        return $"Name: {Name}";
    }


}
