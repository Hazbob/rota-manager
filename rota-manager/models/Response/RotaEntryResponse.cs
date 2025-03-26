namespace rota_manager.models.Response;

public class RotaEntryResponse
{
    public required int EmployeeId { get; set; } 
    public DateTime StartTime { get; set; }
    public int DayOfYear { get; set; }
    public DateTime EndTime { get; set; }
    public required Rota ParentRota { get; set; }
}