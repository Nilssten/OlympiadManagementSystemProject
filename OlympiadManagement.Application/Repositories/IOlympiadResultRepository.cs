using OlympiadManagement.Core;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public interface IOlympiadResultRepository
    {

        Task<List<OlympiadResult>> GetOlympiadResultsAsync();

        Task<OlympiadResult> CreateOlympiadResultAsync(OlympiadResult result);

        Task UpdateOlympiadResultAsync(OlympiadResult result);

        Task<OlympiadResult> GetOlympiadResultAsync(string ID);
        Task<OlympiadResult> GetOlympiadResultAsync(Participant participant);

        Task DeleteOlympiadResultAsync(string ID);


    }
}
