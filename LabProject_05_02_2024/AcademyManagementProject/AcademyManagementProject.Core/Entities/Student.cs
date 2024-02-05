using AcademyManagementProject.Core.Enums;

namespace AcademyManagementProject.Core.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string SerialNumber { get; set; }
    public DateTime CreatedDate { get; set;}
    public DateTime LastModifiedDate { get; set;}
    public DateTime DeletedDate { get; set;}
    public string Status { get; set; }
}
