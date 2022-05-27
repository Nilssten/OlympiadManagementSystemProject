using Microsoft.EntityFrameworkCore;
using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure.DataAccess
{
    public class OrganizerDbRepository : IOrganizerRepository
    {

        private readonly IDbContextFactory<ApplicationDbContext> _factory;
        public OrganizerDbRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }
        public async Task<Organizer> CreateOrganizerAsync(Organizer organizer)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Organizers.Add(organizer);
                await ctx.SaveChangesAsync();
                return organizer;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteOrganizerAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var organizer = await ctx.Organizers.FirstOrDefaultAsync(org => org.OrganizerID == Guid.Parse(ID));
                ctx.Organizers.Remove(organizer);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Organizer> GetOrganizerAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var organizer = await ctx.Organizers.FirstOrDefaultAsync(org => org.OrganizerID == Guid.Parse(ID));
                return organizer;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Organizer>> GetOrganizersAsync()
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                return await ctx.Organizers.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateOrganizerAsync(Organizer organizer)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Update(organizer);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
