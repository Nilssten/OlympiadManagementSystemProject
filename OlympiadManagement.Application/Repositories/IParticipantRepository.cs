using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public interface IParticipantRepository
    {

        Task<List<Participant>> GetParticipantsAsync();

        Task<Participant> CreateParticipantAsync(Participant participant);

        Task UpdateParticipantAsync(Participant participant);

        Task<Participant> GetParticipantAsync(string ID);

        Task DeleteParticipantAsync(string ID);

    }
}
