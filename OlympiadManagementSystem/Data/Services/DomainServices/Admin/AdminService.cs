using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Data.Services.DomainServices
{
    public class AdminService : IAdminService
    {

        private readonly IAdminRepository _repository;
        public AdminService(IAdminRepository repository)
        {
            _repository = repository;
        }
        public async Task<Admin> CreateAdminAsync(Admin admin)
        {
            try
            {
                return await _repository.CreateAdminAsync(admin);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteAdminAsync(string ID)
        {
            try
            {
                await _repository.DeleteAdminAsync(ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Admin> GetAdminAsync(string ID)
        {
            try
            {
                return await _repository.GetAdminAsync(ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Admin>> GetAdminsAsync()
        {
            try
            {
                return await _repository.GetAdminsAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAdminAsync(Admin admin)
        {
            try
            {
                await _repository.UpdateAdminAsync(admin);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
