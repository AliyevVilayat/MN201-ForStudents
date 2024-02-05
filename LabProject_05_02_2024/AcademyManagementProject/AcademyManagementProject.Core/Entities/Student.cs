using AcademyManagementProject.Core.Enums;

namespace AcademyManagementProject.Core.Entities;

public class Student : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string SerialNumber { get; set; }
    public ICollection<Group> Groups { get; set; }

}
