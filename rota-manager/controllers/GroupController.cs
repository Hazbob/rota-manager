using Microsoft.AspNetCore.Mvc;
using rota_manager.models.Request;
using rota_manager.services;

namespace rota_manager.controllers;

public class GroupController : Controller
{
    private readonly GroupService _groupService;
    public GroupController(GroupService groupService)
    {
        _groupService = groupService;
    }

    [HttpPost("[controller]")]
    public async Task<IActionResult> CreateGroup([FromBody]GroupDTO groupBody)
    {
        await _groupService.CreateGroup(groupBody);
        return Created();
    }
}