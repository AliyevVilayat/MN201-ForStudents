namespace AcademyManagementProject.DataAccess.Exceptions;

public class GroupNotFoundException:Exception
{

    public GroupNotFoundException(int id):base($"Group Not Found with {id}")
    {

    }
    public GroupNotFoundException(string message) : base(message)
    {

    }
}
