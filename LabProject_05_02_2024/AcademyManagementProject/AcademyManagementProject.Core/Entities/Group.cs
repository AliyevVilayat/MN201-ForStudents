namespace AcademyManagementProject.Core.Entities;

public class Group:BaseEntity
{
    public string Code { get; set; }

    public ICollection<Student> Students { get; set; }

}
