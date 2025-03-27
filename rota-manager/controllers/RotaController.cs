using Microsoft.AspNetCore.Mvc;
using rota_manager.models.Request;
using rota_manager.services;

namespace rota_manager.controllers;

public class RotaController : Controller
{
  private readonly RotaService _rotaService;

    public RotaController(RotaService rotaService)
    {
      _rotaService = rotaService;
    }
    
    [HttpGet("[controller]/{rotaId:int}")]
    public async Task<IActionResult> GetRotaById([FromRoute]int rotaId)
    {
      var rota = await _rotaService.GetRotaByIdAsync(rotaId);

      return Ok(rota);
    }

    [HttpPost("[controller]")]
    public async Task<IActionResult> CreateRota(RotaResponse rota)
    {
      await _rotaService.CreateRotaAsync(rota);
      return Created();
    }
}

