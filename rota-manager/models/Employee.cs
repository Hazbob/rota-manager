using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rota_manager.models;

[Table("Employees")]
public class Employee
{
    [Key]
    public int EmployeeId { get; set; }
    public ICollection<RotaEntry> RotaEntries { get; set; } = new List<RotaEntry>();
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    
    public Group Group { get; }
}