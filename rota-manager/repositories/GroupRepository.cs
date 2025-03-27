using rota_manager.Data;
using rota_manager.models;

namespace rota_manager.repositories;

public class GroupRepository
{
    private readonly RotaManagerContext _context;
    public GroupRepository(RotaManagerContext context)
    {
        _context = context;
    }

    public async Task<Group> CreateGroup(Group group)
    {
        var newGroup = await _context.Groups.AddAsync(group);
        return newGroup.Entity;
    }
}