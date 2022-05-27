using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public interface IApplicantRepository
    {
        Task<List<Applicant>> GetApplicantsAsync();

        Task<Applicant> CreateApplicantAsync(Applicant applicant);

        Task UpdateApplicantAsync(Applicant applicant);

        Task<Applicant> GetApplicantAsync(string ID);

        Task DeleteApplicantAsync(string ID);


    }
}
