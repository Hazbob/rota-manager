using rota_manager.models;
using rota_manager.models.Request;
using rota_manager.repositories;

namespace rota_manager.services;

public class RotaService
{
    private readonly RotaRepository _rotaRepository;
    public RotaService(RotaRepository rotaRepository)
    {
        _rotaRepository = rotaRepository;
    }

    public async Task<Rota>GetRotaByIdAsync(int rotaId)
    {
      return await _rotaRepository.GetByIdAsync(rotaId);
    }

    public async Task<Rota> CreateRotaAsync(RotaResponse rotaBody)
    {
        var newRota = new Rota
        {
            GroupId = rotaBody.GroupId,
            RotaEntries = rotaBody.RotaEntries,
            WeekOfYear = rotaBody.WeekOfYear,
        }; 
        return await _rotaRepository.CreateAsync(newRota);
    }
}
