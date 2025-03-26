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
        var newEntry = await _rotaEntryService.CreateRotaEntryAsync(rotaEntryBody);
        
        var result = new RotaEntryResponse
        {
            DayOfYear = newEntry.DayOfYear,
            EmployeeId = newEntry.EmployeeId,
            EndTime = newEntry.EndTime,
            StartTime = newEntry.StartTime,
            ParentRota = newEntry.ParentRota
        };
        return Ok(result);
    }
    
}