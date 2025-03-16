using Microsoft.EntityFrameworkCore;
using rota_manager.models;

namespace rota_manager.Data;

public class RotaManagerContext(DbContextOptions<RotaManagerContext> options) : DbContext(options)
{
    public DbSet<Rota> Rotas { get; set; }
    public DbSet<RotaEntry> RotaEntries { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<RotaHistory> RotaHistories { get; set; }
    public DbSet<Employee> Employee { get; set; }
}