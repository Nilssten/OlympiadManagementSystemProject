using OlympiadManagement.Core.Aggregates.EducationAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public interface ISchoolRepository
    {

        Task<List<School>> GetSchoolsAsync();

        Task<School> CreateSchoolAsync(School school);

        Task UpdateSchoolAsync(School school);

        Task<School> GetSchoolAsync(string ID);

        Task DeleteSchoolAsync(string ID);
    }
}
