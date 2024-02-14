

using AcademyManagementProject.Core.Entities;
using AcademyManagementProject.DataAccess.Contexts;
using AcademyManagementProject.DataAccess.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace AcademyManagementProject.DataAccess.Services;

public class GroupService
{
    private readonly AcademyManagementDbContext _context;
    private readonly DbSet<Group> _groupsTable;
    //private readonly AcademyManagementDbContext _context = new AcademyManagementDbContext();


    public GroupService()
    {
        _context = new AcademyManagementDbContext();
        _groupsTable = _context.Set<Group>();
    }

    //Teacher teacher = new Teacher();

    #region Create
    public async Task CreateGroupAsync(Group group)
    {
        await  _groupsTable.AddAsync(group);
        await _context.SaveChangesAsync();
        Console.WriteLine("Group has been succesfully added.");
    }

    public async Task CreateGroupAsync(params Group[] groups)
    {
        await _groupsTable.AddRangeAsync(groups);
        await _context.SaveChangesAsync();
        Console.WriteLine("Groups have been succesfully added.");
    }

    #endregion

    #region Update

    public async Task UpdateGroupAsync(Group group)
    {
        /*        //1-AsNoTracking()
                Group? baseGroup = await _groupsTable.AsNoTracking().SingleOrDefaultAsync(g => g.Id == group.Id);
                if (baseGroup is null)
                {

                    throw new Exception("Group not found");
                }

                group.LastModifiedDate = DateTime.UtcNow;
                _groupsTable.Update(group);
                Console.WriteLine("Group has been succesfully modified");
                await _context.SaveChangesAsync();
        */

        //2-SaveChanges()
        Group? baseGroup = await _groupsTable.SingleOrDefaultAsync(g => g.Id == group.Id);
        if (baseGroup is null)
        {

            throw new Exception("Group not found");
        }

        baseGroup.Code = group.Code;
        baseGroup.LastModifiedDate = DateTime.UtcNow;
        baseGroup.IsDeleted = group.IsDeleted;
        baseGroup.Status = group.Status;

        await _context.SaveChangesAsync();


        Console.WriteLine("Group has been succesfully modified");
    }


    #endregion

    #region Delete
    public async Task DeleteGroupAsync(int id)
    {
        Group? groupdb = await _groupsTable.Where(g => !g.IsDeleted).FirstOrDefaultAsync(g => g.Id == id);
        if (groupdb is null)
        {
            throw new Exception("Group not found");
        }

        groupdb.IsDeleted = true;
        groupdb.DeletedDate = DateTime.UtcNow;

        await _context.SaveChangesAsync();
        Console.WriteLine("Has been succesfully deleted");
    }




    #endregion

    #region Select

    public async Task<Group> GetGroupByIdAsync (int id)
    {
        Group? group = await _groupsTable.FirstOrDefaultAsync(g => g.Id == id);

        if (group is null) 
        {
            throw new GroupNotFoundException(id);
        
        }

        return group;      
    }

    public async Task<Group> GetGroupByCodeAsync(string code)
    {
        Group? group = await _groupsTable.FirstOrDefaultAsync(g => g.Code == code);

        if (group is null)
        {
            throw new Exception("Tapilmadi");

        }

        return group;
    }

    #endregion
}
