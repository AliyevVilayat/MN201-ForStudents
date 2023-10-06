namespace EmployeProject.Core.Entities;

//ctrl + R + G



//Repository Design Pattern -database ile bagli emeliyyatlar burada heyata kececek.
//Service - database ile bagli olan emeliyyatlarin biznes logic burada yerlesecek.
public class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }

    public List<Employee> Employees { get; }

    private static int _idCounter = 1;

    public Department(string departmentName)
    {
        Id = _idCounter;
        DepartmentName = departmentName;
        Employees = new List<Employee>();

        _idCounter++;
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
}
