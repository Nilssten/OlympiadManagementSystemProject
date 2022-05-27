using OlympiadManagement.Core.Aggregates.UserProfileAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public interface IUserProfileRepository
    {


        Task<List<UserProfile>> GetUserProfilesAsync();

        Task<UserProfile> CreateUserProfileAsync(UserProfile profile);

        Task UpdateUserProfileAsync(UserProfile profile);

        Task<UserProfile> GetUserProfileAsync(string ID);

        Task DeleteUserProfileAsync(string ID);


    }
}
