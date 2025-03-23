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
        var listTest = new List<Rota>();
        var newItem = await _rotaRepository.testc();
        listTest.Add(newItem);
        return listTest;
    }
}