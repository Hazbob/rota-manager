using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rota_manager.models;

[Table("Groups")]
public class Group
{
    [Key]
    public int GroupId { get; set; }
    public required string GroupName { get; set; }
    public ICollection<Rota> Rotas { get; }
    public ICollection<Employee> Employees { get; }
}