using System.ComponentModel.DataAnnotations;

namespace rota_manager.models;

public class Rota
{
    [Key]
    public int RotaId { get; set; }
    public int WeekOfYear { get; set; }
    public int GroupId { get; set; }
    public ICollection<RotaEntry> RotaEntries { get; private set; } = new List<RotaEntry> { };
}