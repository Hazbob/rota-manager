using rota_manager.Data;

namespace rota_manager.repositories;

public class RotaRepository
{
    private readonly RotaManagerContext _context;
    public RotaRepository(RotaManagerContext context)
    {
        _context = context;
    }
}