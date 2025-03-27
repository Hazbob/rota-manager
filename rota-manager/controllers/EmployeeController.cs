using Microsoft.AspNetCore.Mvc;
using rota_manager.models.Request;
using rota_manager.services;

namespace rota_manager.controllers;

public class EmployeeController : Controller
{
    private readonly EmployeeService _employeeService;
    public EmployeeController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    
    [HttpPost("[controller]")]
    public async Task<IActionResult> CreateEmployee([FromBody]EmployeeRequest employeeBody)
    {
        await _employeeService.CreateEmployee(employeeBody);
        return Created();
    }
}