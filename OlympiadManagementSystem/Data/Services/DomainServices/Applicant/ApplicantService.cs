using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Data.Services.DomainServices
{
    public class ApplicantService : IApplicantService
    {

        private readonly IApplicantRepository _repository;
        public ApplicantService(IApplicantRepository repository)
        {
            _repository = repository;
        }
        public async Task<Applicant> CreateApplicantAsync(Applicant applicant)
        {
            try
            {
                return await _repository.CreateApplicantAsync(applicant);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteApplicantAsync(string ID)
        {
            try
            {
                await _repository.DeleteApplicantAsync(ID);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<Applicant> GetApplicantAsync(string ID)
        {
            try
            {
                return await _repository.GetApplicantAsync(ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Applicant>> GetApplicantsAsync()
        {
            try
            {

                return await _repository.GetApplicantsAsync();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task UpdateApplicantAsync(Applicant applicant)
        {
            try
            {
                await _repository.UpdateApplicantAsync(applicant);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
