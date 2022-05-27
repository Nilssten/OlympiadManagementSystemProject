using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Data.Services.DomainServices
{
    public class OrganizerService : IOrganizerService
    {
        private readonly IOrganizerRepository _repository;
        public OrganizerService(IOrganizerRepository repository)
        {
            _repository = repository;
        }
        public async Task<Organizer> CreateOrganizerAsync(Organizer organizer)
        {
            try
            {
                return await _repository.CreateOrganizerAsync(organizer);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteOrganizerAsync(string ID)
        {
            try
            {
                await _repository.DeleteOrganizerAsync(ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Organizer> GetOrganizerAsync(string ID)
        {
            try
            {
                return await _repository.GetOrganizerAsync(ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Organizer>> GetOrganizersAsync()
        {
            try
            {
                return await _repository.GetOrganizersAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateOrganizerAsync(Organizer organizer)
        {
            try
            {
                await _repository.UpdateOrganizerAsync(organizer);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
