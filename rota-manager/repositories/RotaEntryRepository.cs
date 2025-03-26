using rota_manager.Data;
using rota_manager.models;

namespace rota_manager.repositories;

public class RotaEntryRepository
{
    private readonly RotaManagerContext _context;
    public RotaEntryRepository(RotaManagerContext context)
    {
        _context = context;
    }
    public async Task<RotaEntry> CreateRotaEntryAsync(RotaEntry rota)
    {
        var newEntry = await _context.RotaEntries.AddAsync(rota);
        await _context.SaveChangesAsync();
        return newEntry.Entity;

    }
}