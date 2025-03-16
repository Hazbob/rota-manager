using Microsoft.AspNetCore.Mvc;

namespace rota_manager.controllers;

public class RotaController : Controller
{
    public RotaController()
    {
        
    }
    
    [HttpGet("[controller]/{groupId:int}")]
    public async Task<IActionResult> GetAllRotas([FromRoute]int groupId)
    {
        return Ok("helo");
    }
}