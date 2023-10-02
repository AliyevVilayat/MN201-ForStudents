namespace ExceptionTesting;

public class Group
{
    public string GroupId { get; set; }
    //Group id olmadan instance alina bilmez.

    //Group daxilinde mueyyen telebeler olmalidir
    private readonly Student[] _students;

    public Student this[int index]
    {

        get
        {
            if (_students.Length > index)
            {
                return _students[index];
            }
            {
                //IndexOutOfRangeException indexOutOfRangeException = new($"Gonderilen indexde {index} telebe movcud deyil.");
                //throw new NullReferenceException("Null reference", indexOutOfRangeException);
                //MyCustomException myCustomException = new($"Gonderilen indexde {index} telebe movcud deyil.");
                //MyCustomException myCustomException = new();
                //throw myCustomException;
                throw new Exception("custom message");
            }
            
        }

        set
        {
            _students[index] = value;
        }
    }

    public Group(string groupId,int groupSize)
    {
        GroupId = groupId;  
        _students = new Student[groupSize];
    }
    
/*    public Student GetStudentByIndex(int index)
    {
        return _students[index];
    }

    public void AddStudent(Student student,int index) {

        _students[index] = student;
        Console.WriteLine("Telebe ugurla qeyd edildi.");
    }*/

}
