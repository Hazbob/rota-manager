using rota_manager.Data;
using rota_manager.models;

namespace rota_manager.repositories;

public class EmployeeRepository
{
    private readonly RotaManagerContext _context;
    public EmployeeRepository(RotaManagerContext context)
    {
        _context = context;
    }

    public async Task<Employee> CreateEmployee(Employee employee)
    {
        var newEmployee = await _context.Employee.AddAsync(employee);
        await _context.SaveChangesAsync();
        return newEmployee.Entity;
    }
}