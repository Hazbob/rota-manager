using Microsoft.AspNetCore.Mvc;
using rota_manager.models;
using rota_manager.models.Request;
using rota_manager.models.Response;
using rota_manager.services;

namespace rota_manager.controllers;

public class RotaEntryController : Controller
{
    private readonly RotaEntryService _rotaEntryService;
    public RotaEntryController(RotaEntryService rotaEntryService)
    {
        _rotaEntryService = rotaEntryService;
    }
    
    [HttpPost("[controller]")]
    public async Task<IActionResult> CreateRotaEntry(RotaEntryRequest rotaEntryBody)
    {
        await _rotaEntryService.CreateRotaEntryAsync(rotaEntryBody);
        return Created();
    }
    
}