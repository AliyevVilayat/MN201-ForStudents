

using AcademyManagementProject.Core.Entities;
using AcademyManagementProject.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AcademyManagementProject.DataAccess.Services;

public class GroupService
{
    private readonly AcademyManagementDbContext _context;
    //private readonly AcademyManagementDbContext _context = new AcademyManagementDbContext();


    public GroupService()
    {
        _context = new AcademyManagementDbContext();
    }

    #region Create
    public async Task CreateGroupAsync(Group group)
    {
        await _context.Groups.AddAsync(group);
        await _context.SaveChangesAsync();
        Console.WriteLine("Group has been succesfully added.");
    }

    public async Task CreateGroupAsync(params Group[] groups)
    {
        await _context.Groups.AddRangeAsync(groups);
        await _context.SaveChangesAsync();
        Console.WriteLine("Groups have been succesfully added.");
    }

    #endregion

    #region Update

    public async Task UpdateGroupAsync(Group group)
    {
        /*        //1-AsNoTracking()
                Group? baseGroup = await _context.Groups.AsNoTracking().SingleOrDefaultAsync(g => g.Id == group.Id);
                if (baseGroup is null)
                {

                    throw new Exception("Group not found");
                }

                group.LastModifiedDate = DateTime.UtcNow;
                _context.Groups.Update(group);
                Console.WriteLine("Group has been succesfully modified");
                await _context.SaveChangesAsync();
        */

        //2-SaveChanges()
        Group? baseGroup = await _context.Groups.SingleOrDefaultAsync(g => g.Id == group.Id);
        if (baseGroup is null)
        {

            throw new Exception("Group not found");
        }

        baseGroup.Code = group.Code;
        baseGroup.LastModifiedDate = DateTime.UtcNow;
        baseGroup.Status = group.Status;

        await _context.SaveChangesAsync();


        Console.WriteLine("Group has been succesfully modified");
    }


    #endregion
}
