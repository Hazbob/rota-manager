using Microsoft.EntityFrameworkCore;
using rota_manager.Data;
using rota_manager.models;

namespace rota_manager.repositories;

public class RotaRepository
{
    private readonly RotaManagerContext _context;
    public RotaRepository(RotaManagerContext context)
    {
        _context = context;
    }

    public async Task<Rota> testc()
    {
        return await _context.Rotas.FirstOrDefaultAsync();
    }
}