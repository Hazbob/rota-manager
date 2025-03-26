using rota_manager.Data;

namespace rota_manager.repositories;

public class BaseRepository(RotaManagerContext context)
{
    protected readonly RotaManagerContext Context = context;
}