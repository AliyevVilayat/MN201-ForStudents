
//using AcademyManagementProject.Core.Entities;
//using AcademyManagementProject.Core.Enums;
//using AcademyManagementProject.DataAccess.Contexts;

//Console.WriteLine("Hello, World!");


//AcademyManagementDbContext context = new();

////Add Student

//List<Group> groups = new();
//List<Student> students = new();
//Student student = new();
//Student student2 = new();
//Group group = new();

//student = new Student() { 

//    Name = "TestName",
//    Surname = "TestSurname",
//    Username= "TestUsername",
//    Email = "TestEmail",
//    SerialNumber = "AZE12345678",
//    Status =StudentStatus.Active.ToString(),
//    CreatedDate = DateTime.Now,
//    LastModifiedDate = DateTime.Now,
//    Groups = groups,
//};

// student2 = new Student()
//{

//    Name = "TestName2",
//    Surname = "TestSurname2",
//    Username = "TestUsername2",
//    Email = "TestEmail2",
//    SerialNumber = "AZE12345679",
//    Status = StudentStatus.Graduated.ToString(),
//    CreatedDate = DateTime.Now,
//    LastModifiedDate = DateTime.Now,
//    Groups = groups,
//};

//students.Add(student);
//students.Add(student2);


// group = new Group()
//{
//    Code = "MN-201",
//    CreatedDate = DateTime.Now,
//    LastModifiedDate = DateTime.Now,
//    Status = GroupStatus.Online.ToString(),
//    Students = students,
//};

//groups.Add(group);



//context.Students.AddRange(students);
//context.Groups.AddRange(groups);
//await context.SaveChangesAsync();
//Console.Read();



/*#region Group Create
using AcademyManagementProject.Core.Entities;
using AcademyManagementProject.Core.Enums;
using AcademyManagementProject.DataAccess.Services;

Group group = new Group()
{
    Code = "MN202",
    Status = GroupStatus.Online.ToString()
};

GroupService groupService = new GroupService();
await groupService.CreateGroupAsync(group);

#endregion*/

using AcademyManagementProject.Core.Entities;
using AcademyManagementProject.Core.Enums;
using AcademyManagementProject.DataAccess.Exceptions;
using AcademyManagementProject.DataAccess.Services;

/*Group group =  new Group()
{
    Id = 2,
    Code="MN205",
    Status = GroupStatus.Offline.ToString(),
};

GroupService groupService = new GroupService();
await groupService.UpdateGroupAsync(group);*/

////Delete
//GroupService groupService = new();
//await groupService.DeleteGroupAsync(2);


GroupService groupService = new GroupService();

try
{
    Group group = await groupService.GetGroupByIdAsync(11);
    Console.WriteLine(group.Code);

}catch(GroupNotFoundException gex)
{
    Console.WriteLine(gex.Message);
}


catch(Exception ex)
{

}
finally
{
    Console.WriteLine("Finally blocks always execute");

}





