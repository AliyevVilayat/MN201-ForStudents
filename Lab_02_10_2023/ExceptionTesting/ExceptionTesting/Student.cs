namespace ExceptionTesting;

public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }    
    public string Surname { get; set; }

    public Student(string id,string name,string surname)
    {
        Id = id;
        Name = name;
        Surname = surname;
    }

    public override string ToString()
    {
        string info = $"Telebenin adi: {Name}";
        return info;
    }
}
