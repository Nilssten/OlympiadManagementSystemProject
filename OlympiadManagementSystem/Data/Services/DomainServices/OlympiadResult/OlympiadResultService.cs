using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Data.Services.DomainServices
{
    public class OlympiadResultService : IOlympiadResultService
    {

        private readonly IOlympiadResultRepository _repository;
        public OlympiadResultService(IOlympiadResultRepository repository)
        {
            _repository = repository;
        }
        public async Task<OlympiadResult> CreateOlympiadResultAsync(OlympiadResult result)
        {
            try
            {
                return await _repository.CreateOlympiadResultAsync(result);   
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteOlympiadResultAsync(string ID)
        {
            try
            {
                await _repository.DeleteOlympiadResultAsync(ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<OlympiadResult> GetOlympiadResultAsync(string ID)
        {
            try
            {
                return await _repository.GetOlympiadResultAsync(ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<OlympiadResult> GetOlympiadResultAsync(Participant participant)
        {
            try
            {
                return await _repository.GetOlympiadResultAsync(participant);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<OlympiadResult>> GetOlympiadResultsAsync()
        {
            try
            {
                return await _repository.GetOlympiadResultsAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateOlympiadResultAsync(OlympiadResult result)
        {
            try
            {
                await _repository.UpdateOlympiadResultAsync(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
