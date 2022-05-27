using Microsoft.EntityFrameworkCore;
using OlympiadManagement.Core;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using OlympiadManagement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public class OlympiadResultDbRepository : IOlympiadResultRepository
        
    {

        private readonly IDbContextFactory<ApplicationDbContext> _factory;
       
        public OlympiadResultDbRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }


        public async  Task<OlympiadResult> CreateOlympiadResultAsync(OlympiadResult result)
        {

            try
            {

            using var ctx = _factory.CreateDbContext();
            ctx.OlympiadResults.Add(result);
            await ctx.SaveChangesAsync();
            return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteOlympiadResultAsync(string ID)
        {
            try
            {

            using var ctx = _factory.CreateDbContext();
            var result = await ctx.OlympiadResults.FirstOrDefaultAsync(or => or.OlympiadResultID == Guid.Parse(ID));
            ctx.OlympiadResults.Remove(result);
            await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<OlympiadResult> GetOlympiadResultAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var result = await ctx.OlympiadResults.FirstOrDefaultAsync(or => or.OlympiadResultID == Guid.Parse(ID));
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<OlympiadResult> GetOlympiadResultAsync(Participant participant)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();

                var olympiadResult = await ctx.OlympiadResults
                    .FirstOrDefaultAsync(or => or.ParticipantID == participant.ParticipantID);

                return olympiadResult;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<OlympiadResult>> GetOlympiadResultsAsync()
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                return await ctx.OlympiadResults.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateOlympiadResultAsync(OlympiadResult result)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Update(result);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
