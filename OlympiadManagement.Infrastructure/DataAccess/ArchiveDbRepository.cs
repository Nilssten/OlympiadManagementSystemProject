using Microsoft.EntityFrameworkCore;
using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.OlympiadAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure.DataAccess
{
    public class ArchiveDbRepository : IArchiveRepository
    {

        private readonly IDbContextFactory<ApplicationDbContext> _factory;
        public ArchiveDbRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }
        public async Task<Archive> CreateArchiveAsync(Archive archive)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Archives.Add(archive);
                await ctx.SaveChangesAsync();
                return archive;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteArchiveAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var archive = await ctx.Archives.FirstOrDefaultAsync(ar => ar.ArchiveID == Guid.Parse(ID));
                ctx.Archives.Remove(archive);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Archive> GetArchiveAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var archive = await ctx.Archives.FirstOrDefaultAsync(ar => ar.ArchiveID == Guid.Parse(ID));
                return archive;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Archive>> GetArchivesAsync()
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                return await ctx.Archives.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateArchiveAsync(Archive archive)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Archives.Update(archive);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
