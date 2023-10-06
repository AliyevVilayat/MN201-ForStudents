
using EmployeProject.Core.Entities;
using EmployeProject.Core.Exceptions;
using EmployeProject.Core.Services;

//Department department = new("IT");

//Employee employeeForDepartment = new("Kamran", "Jabiyev", "kamran@code.edu.az");
//Employee employeeForDepartment2 = new("Kamran2", "Jabiyev", "kamran@code.edu.az");
//Employee employeeForDepartment3 = new("Kamran3", "Jabiyev", "kamran@code.edu.az");

//EmployeeService employeeService = new();

//department.CreateEmployee(employeeForDepartment); // => department.Employees.Add(employeeForDepartment);
//department.CreateEmployee(employeeForDepartment2); 
//department.CreateEmployee(employeeForDepartment3); 

//Console.WriteLine("ID:" + department.Id + " Name:" + department.DepartmentName);

//foreach (var employee in department.Employees)
//{
//    Console.WriteLine(employee); // => Console.WriteLine(employee.ToString());
//}


//foreach (var employee in department.GetAllEmployee())
//{
//    Console.WriteLine(employee); // => Console.WriteLine(employee.ToString());
//}




try
{

    Department department = new("IT");
    Employee employeeForDepartment = new("Kamran", "Jabiyev", "kamran@code.edu.az");
    Employee employeeForDepartment2 = new("Vilayat", "Aliyev", "vilayat@code.edu.az");
    department.CreateEmployee(employeeForDepartment);
    department.CreateEmployee(employeeForDepartment2);
    //department.UpdateEmployee(employeeForDepartment2, 1);

    Console.WriteLine(department.GetEmployeeById(5));

/*    foreach (var employee in department.GetAllEmployee())
    {
        Console.WriteLine(employee); // => Console.WriteLine(employee.ToString());
    }*/

}
catch (EmployeeNotFoundException ex)
{

    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}






