
using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Data.Services.DomainServices
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _repository;

        public UserProfileService(IUserProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserProfile> CreateUserProfileAsync(UserProfile profile)
        {
            return await _repository.CreateUserProfileAsync(profile);
        }

        public async Task DeleteUserProfileAsync(string ID)
        {
            await _repository.DeleteUserProfileAsync(ID);
        }

        public async Task<UserProfile> GetUserProfileAsync(string ID)
        {
            return await _repository.GetUserProfileAsync(ID);
        }

        public async Task<List<UserProfile>> GetUserProfilesAsync()
        {
            return await _repository.GetUserProfilesAsync();
        }

        public async Task UpdateUserProfileAsync(UserProfile profile)
        {
            await _repository.UpdateUserProfileAsync(profile);
        }
    }
}
