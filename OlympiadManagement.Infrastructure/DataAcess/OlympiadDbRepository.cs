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
            try
            {
                using var ctx = _dbFactory.CreateDbContext();
                ctx.Olympiads.Add(olympiad);
                await ctx.SaveChangesAsync();
                return olympiad;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task DeleteOlympiadAsync(string ID)
        {

            try
            {
                using var ctx = _dbFactory.CreateDbContext();
                var olympiad = await ctx.Olympiads.FirstOrDefaultAsync(ol => ol.OlympiadID == Guid.Parse(ID));

                //to refactor
                if (olympiad is null)
                    return;

                ctx.Olympiads.Remove(olympiad);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
            



            
        }

        public async Task<Olympiad> GetOlympiadAsync(string ID)
        {
            try
            {
                using var ctx = _dbFactory.CreateDbContext();
                return await ctx.Olympiads.FirstOrDefaultAsync(ol => ol.OlympiadID == Guid.Parse(ID));
            }
            catch (Exception)
            {

                throw;
            }

            
        }

        public async Task<List<Olympiad>> GetOlympiadsAsync()
        {
            try
            {
                using var ctx = _dbFactory.CreateDbContext();
                return await ctx.Olympiads.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task UpdateOlympiadAsync(Olympiad olympiad)
        {
            try
            {
                using var ctx = _dbFactory.CreateDbContext();
            ctx.Olympiads.Update(olympiad);
            await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
