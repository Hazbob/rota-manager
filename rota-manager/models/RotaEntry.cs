namespace rota_manager.models;

public class RotaEntry
{
    public int RotaId { get; set; }
    public string EmployeeId { get; set; } 
    public DateTime StartTime { get; set; }
    public int DayOfYear { get; set; }
    public DateTime EndTime => StartTime.AddHours(8.5);
    public required Rota ParentRota { get; set; }
}