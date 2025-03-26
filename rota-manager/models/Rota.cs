using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rota_manager.models;

[Table("Rotas")]
public class Rota
{
    [Key]
    public int RotaId { get; set; }
    public int WeekOfYear { get; set; }
    public int GroupId { get; set; }
    public ICollection<RotaEntry> RotaEntries { get; set; } = new List<RotaEntry> { };
}
