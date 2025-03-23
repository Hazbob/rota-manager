using System.ComponentModel.DataAnnotations;

namespace rota_manager.models;

public class RotaHistory
{
    [Key]
    public int RotaHistoryId { get; set; }
    public int RotaId { get; set; }
    public DateTime EditedTime { get; set; }
    public required string UserId { get; set; }
    public string? Notes { get; set; }
}