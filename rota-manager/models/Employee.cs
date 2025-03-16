namespace rota_manager.models;

public class Employee
{
    public required string Id { get; set; }
    public ICollection<RotaEntry>? RotaEntries { get; set; }
}