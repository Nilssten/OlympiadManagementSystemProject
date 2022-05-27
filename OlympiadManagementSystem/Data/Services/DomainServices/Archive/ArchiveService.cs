using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.OlympiadAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Data.Services.DomainServices
{
    public class ArchiveService : IArchiveService
    {
        private readonly IArchiveRepository _repository;
        public ArchiveService(IArchiveRepository repository)
        {
            _repository = repository;
        }
        public async Task<Archive> CreateArchiveAsync(Archive archive)
        {
            try
            {
                return await _repository.CreateArchiveAsync(archive);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteArchiveAsync(string ID)
        {
            try
            {
                await _repository.DeleteArchiveAsync(ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Archive> GetArchiveAsync(string ID)
        {
            try
            {
                return await _repository.GetArchiveAsync(ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Archive>> GetArchivesAsync()
        {
            try
            {
                return await _repository.GetArchivesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateArchiveAsync(Archive archive)
        {
            try
            {
                await _repository.UpdateArchiveAsync(archive);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
