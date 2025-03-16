using rota_manager.models;
using rota_manager.repositories;

namespace rota_manager.services;

public class RotaService
{
    private readonly RotaRepository _rotaRepository;
    public RotaService(RotaRepository rotaRepository)
    {
        _rotaRepository = rotaRepository;
    }

    public async Task<IReadOnlyList<Rota>> GetAllRotasForGroup()
    {
        _rotaRepository.GetAllRotasForGroup()
    }
}