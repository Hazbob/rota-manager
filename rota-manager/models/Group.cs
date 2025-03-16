namespace rota_manager.models;

public class Group
{
    public required string GroupName { get; set; }
    public int GroupId { get; set; }
    public ICollection<Rota>? Rotas { get; set; }
}