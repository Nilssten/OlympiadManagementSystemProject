using Microsoft.EntityFrameworkCore;
using OlympiadManagement.Application;
using OlympiadManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure
{
    public class OlympiadDbRepository : IOlympiadRepository
    {

        private readonly IDbContextFactory<ApplicationDbContext> _dbFactory;

        public OlympiadDbRepository(IDbContextFactory<ApplicationDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Olympiad> CreateOlympiadAsync(Olympiad olympiad)
        {
            using var ctx = _dbFactory.CreateDbContext();
            ctx.Olympiads.Add(olympiad);
            await ctx.SaveChangesAsync();
            return olympiad;
        }

        public async Task DeleteOlympiadAsync(string ID)
        {
            using var ctx = _dbFactory.CreateDbContext();
            var olympiad = ctx.Olympiads.FirstOrDefault(ol => ol.OlympiadID.ToString() == ID);
            ctx.Olympiads.Remove(olympiad);
            await ctx.SaveChangesAsync();
        }

        public async Task<Olympiad> GetOlympiadAsync(string ID)
        {
            using var ctx = _dbFactory.CreateDbContext();
            return await ctx.Olympiads.FirstOrDefaultAsync(ol => ol.OlympiadID.ToString() == ID);
        }

        public async Task<List<Olympiad>> GetOlympiadsAsync()
        {
            using var ctx = _dbFactory.CreateDbContext();
            return await ctx.Olympiads.ToListAsync();
        }

        public async Task UpdateOlympiadAsync(Olympiad olympiad)
        {
            using var ctx = _dbFactory.CreateDbContext();
            ctx.Olympiads.Update(olympiad);
            await ctx.SaveChangesAsync();
        }
    }
}
