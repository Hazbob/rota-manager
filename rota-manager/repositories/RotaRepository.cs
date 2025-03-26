using Microsoft.EntityFrameworkCore;
using rota_manager.Data;
using rota_manager.models;
using rota_manager.models.Request;

namespace rota_manager.repositories;

public class RotaRepository
{
    private readonly RotaManagerContext _context;
    public RotaRepository(RotaManagerContext context)
    {
        _context = context;
    }
    public async Task<Rota?> GetByIdAsync(int rotaId)
    {
        return await _context.Rotas.SingleOrDefaultAsync(rota => rota.RotaId == rotaId);
    }

    public async Task<Rota> CreateAsync(Rota rota)
    {
        var createdRota = await _context.Rotas.AddAsync(rota);
        await _context.SaveChangesAsync();
        return createdRota.Entity;
    }
}
