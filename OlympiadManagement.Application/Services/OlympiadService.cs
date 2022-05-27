using OlympiadManagement.Application;
using OlympiadManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Services
{
    public class OlympiadService : IOlympiadService
    {

        private readonly IOlympiadRepository _repository;
        public OlympiadService(IOlympiadRepository repository)
        {
            _repository = repository;
        }

        public async Task<Olympiad> CreateOlympiadAsync(Olympiad olympiad)
        {
            return await _repository.CreateOlympiadAsync(olympiad);
        }

        public async Task DeleteOlympiadAsync(string ID)
        {
            await _repository.DeleteOlympiadAsync(ID);
        }

        public async Task<Olympiad> GetOlympiadAsync(string ID)
        {
            return await _repository.GetOlympiadAsync(ID);
        }

        public async Task<List<Olympiad>> GetOlympiadsAsync()
        {
            return await _repository.GetOlympiadsAsync();
        }

        public Task UpdateOlympiadAsync(Olympiad olympiad)
        {
            throw new NotImplementedException();
        }
    }
}
