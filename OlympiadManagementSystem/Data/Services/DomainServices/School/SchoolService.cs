using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.EducationAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Data.Services.DomainServices
{
    public class SchoolService : ISchoolService
    {

        private readonly ISchoolRepository _repository;
        public SchoolService(ISchoolRepository repository)
        {
            _repository = repository;
        }
        public async Task<School> CreateSchoolAsync(School school)
        {
            try
            {
                return await _repository.CreateSchoolAsync(school);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteSchoolAsync(string ID)
        {
            try
            {
                await _repository.DeleteSchoolAsync(ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<School> GetSchoolAsync(string ID)
        {
            try
            {
                return await _repository.GetSchoolAsync(ID);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<List<School>> GetSchoolsAsync()
        {
            try
            {
                return await _repository.GetSchoolsAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateSchoolAsync(School school)
        {
            try
            {
                await _repository.UpdateSchoolAsync(school);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
