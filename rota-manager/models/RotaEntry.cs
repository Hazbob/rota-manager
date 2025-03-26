using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rota_manager.models;

[Table("RotaEntries")]
public class RotaEntry
{
    [Key]
    public int RotaEntryId { get; set; }
    public int EmployeeId { get; set; } 
    public DateTime StartTime { get; set; }
    public int DayOfYear { get; set; }
    public DateTime EndTime { get; set; }
    public required Rota ParentRota { get; set; }
}
