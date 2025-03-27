using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;
using rota_manager.models.Request;
using rota_manager.models.Response;
using rota_manager.repositories;
using Group = rota_manager.models.Group;

namespace rota_manager.services;

public class GroupService
{
    private readonly GroupRepository _groupRepository;
    public GroupService(GroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public async Task<GroupDTO> CreateGroup(GroupDTO groupBody)
    {
        Group newGroup = new()
        {
            GroupName = groupBody.GroupName
        };
        var resultGroup = await _groupRepository.CreateGroup(newGroup);
        var mappedResult = new GroupDTO
        {
            GroupName = resultGroup.GroupName
        };
        return mappedResult;
    }
}