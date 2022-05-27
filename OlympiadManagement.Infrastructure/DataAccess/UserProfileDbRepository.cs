using Microsoft.EntityFrameworkCore;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using OlympiadManagement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public class UserProfileDbRepository : IUserProfileRepository
    {


        private readonly IDbContextFactory<ApplicationDbContext> _factory;

        public UserProfileDbRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }



        public async Task<UserProfile> CreateUserProfileAsync(UserProfile profile)
        {

            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.UserProfiles.Add(profile);
                await ctx.SaveChangesAsync();

                return profile;
            }
            catch (Exception)
            {

                throw;
            }


        }

     

        public async Task DeleteUserProfileAsync(string ID)
        {

            try
            {
                using var ctx = _factory.CreateDbContext();
                var profile = await ctx.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileID == Guid.Parse(ID));

                //to refactor
                if (profile is null) return;

                ctx.UserProfiles.Remove(profile);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }

        }


        public async Task<UserProfile> GetUserProfileAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                return await ctx.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileID == Guid.Parse(ID));
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<List<UserProfile>> GetUserProfilesAsync()
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                return await ctx.UserProfiles.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }

        }



        public async Task UpdateUserProfileAsync(UserProfile profile)
        {

            try
            {
                using var ctx = _factory.CreateDbContext();


                var dbProfile = ctx.UserProfiles.FirstOrDefault(up => up.UserProfileID == profile.UserProfileID);
                var basicInfo = BasicInfo.CreateBasicInfo(profile.BasicInfo.FirstName, profile.BasicInfo.LastName, profile.BasicInfo.Email,
                   profile.BasicInfo.Adress, profile.BasicInfo.DateOfBirth, profile.BasicInfo.PersonalCode, profile.BasicInfo.PhoneNumber);

                dbProfile.UpdateBasicInfo(basicInfo);

                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }

        }

     
    }
}
