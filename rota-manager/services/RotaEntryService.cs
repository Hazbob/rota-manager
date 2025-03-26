using rota_manager.models;
using rota_manager.models.Request;
using rota_manager.repositories;

namespace rota_manager.services;

public class RotaEntryService
{
    private readonly RotaEntryRepository _rotaEntryRepository;
    public RotaEntryService(RotaEntryRepository rotaEntryRepository)
    {
        _rotaEntryRepository = rotaEntryRepository;
    }

    public async Task<RotaEntry> CreateRotaEntryAsync(RotaEntryRequest rotaEntryBody)
    {
        var newRotaEntry = new RotaEntry
        {
            DayOfYear = rotaEntryBody.DayOfYear,
            EmployeeId = rotaEntryBody.EmployeeId,
            EndTime = rotaEntryBody.EndTime,
            StartTime = rotaEntryBody.StartTime,
            ParentRota = rotaEntryBody.ParentRota
        };
        var newEntry = await _rotaEntryRepository.CreateRotaEntryAsync(newRotaEntry);
        return newEntry;
    }
}