using rota_manager.models;
using rota_manager.models.Request;
using rota_manager.models.Response;
using rota_manager.repositories;

namespace rota_manager.services;

public class EmployeeService
{
    private readonly EmployeeRepository _employeeRepository;
    public EmployeeService(EmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<EmployeeResponse> CreateEmployee(EmployeeRequest employeeBody)
    {
        Employee newEmployee = new()
        {
            FirstName = employeeBody.FirstName,
            LastName = employeeBody.LastName
        };
        var result = await _employeeRepository.CreateEmployee(newEmployee);
        EmployeeResponse mappedResult = new()
        {
            FirstName = result.FirstName,
            LastName = result.LastName
        };

        return mappedResult;
    }
}