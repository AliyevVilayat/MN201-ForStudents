using EmployeProject.Core.Entities;
using EmployeProject.Core.Exceptions;

namespace EmployeProject.Core.Services;

public static class EmployeeService
{

    //CRUD Read,  Create, Update,Delete

    #region Create
    public static void CreateEmployee(this Department department, Employee employee)
    {
        department.Employees.Add(employee);
    }

    #endregion

    #region Read

    //GetAll
    //GetById
    //GetByName

    public static List<Employee> GetAllEmployee(this Department department)
    {

        return department.Employees;
    }

    public static Employee GetEmployeeById(this Department department, int id)
    {

        Employee? employee = department.Employees.FirstOrDefault(e => e.Id == id);
        if (employee is not null)
        {

            return employee;
        }
        else
        {
            throw new EmployeeNotFoundException("Bu id-e sahib employee database-de yoxdur");
        }
    }


    #endregion

    #region Update
    public static void UpdateEmployee(this Department department, Employee updateEmployeeObject, int id)
    {
        Employee? employee = department.Employees.Find(e => e.Id == id); //=> department.GetAllEmployee() 
        if(employee is not null)
        {

            employee.Name = updateEmployeeObject.Name;
            employee.Surname = updateEmployeeObject.Surname;
            employee.Email = updateEmployeeObject.Email;
        }
        else
        {
            throw new EmployeeNotFoundException("Bu id-e sahib employee database-de yoxdur");
        }
    }
    #endregion

    #region Delete

    public static void DeleteEmlpoyee(this Department department, int id)
    {
        Employee? employee = department.Employees.Find(e => e.Id == id); //=> department.GetAllEmployee() 
        
        if (employee is not null)
        {
            department.Employees.Remove(employee);
        }
        else
        {
            throw new EmployeeNotFoundException("Bu id-e sahib employee database-de yoxdur");
        }
    }
    #endregion

}
