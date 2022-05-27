using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Data.Services.DomainServices
{
    public class ParticipantService : IParticipantSevice
    {

        private readonly IParticipantRepository _repository;
        public ParticipantService(IParticipantRepository repository)
        {
            _repository = repository;
        }
        public async Task<Participant> CreateParticipantAsync(Participant participant)
        {
            return await _repository.CreateParticipantAsync(participant);
        }

        public async Task DeleteParticipantAsync(string ID)
        {
            await _repository.DeleteParticipantAsync(ID);
        }

        public async Task<Participant> GetParticipantAsync(string ID)
        {
            return await _repository.GetParticipantAsync(ID);
        }

        public async Task<List<Participant>> GetParticipantsAsync()
        {
            return await _repository.GetParticipantsAsync();
        }

        public async Task UpdateParticipantAsync(Participant participant)
        {
            await _repository.UpdateParticipantAsync(participant);
        }
    }
}
