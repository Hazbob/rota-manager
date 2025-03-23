using System.ComponentModel.DataAnnotations;

namespace rota_manager.models;

public class Group
{
    [Key]
    public int GroupId { get; set; }
    public required string GroupName { get; set; }
    public ICollection<Rota>? Rotas { get; set; }
}