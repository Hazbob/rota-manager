namespace rota_manager.models.Request;

public class RotaResponse
{
    public int WeekOfYear { get; private set; }
    public int GroupId { get; private set; }
    public ICollection<RotaEntry> RotaEntries { get; set; } = new List<RotaEntry>();
}