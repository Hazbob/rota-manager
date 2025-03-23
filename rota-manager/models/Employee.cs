using System.ComponentModel.DataAnnotations;

namespace rota_manager.models;

public class Employee
{
    [Key]
    public int InternalEmployeeId { get; set; }
    public required string Id { get; set; }
    public ICollection<RotaEntry>? RotaEntries { get; set; }
}