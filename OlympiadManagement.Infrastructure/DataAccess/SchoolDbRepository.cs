using Microsoft.EntityFrameworkCore;
using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.EducationAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure.DataAccess
{
    public class SchoolDbRepository : ISchoolRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _factory;
        public SchoolDbRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }
        public async Task<School> CreateSchoolAsync(School school)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Schools.Add(school);
                await ctx.SaveChangesAsync();
                return school;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteSchoolAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var school = await ctx.Schools.FirstOrDefaultAsync(sc => sc.SchoolID == Guid.Parse(ID));
                ctx.Schools.Remove(school);
                await ctx.SaveChangesAsync(); 


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<School> GetSchoolAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var school = await ctx.Schools.FirstOrDefaultAsync(sc => sc.SchoolID == Guid.Parse(ID));
                return school;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<School>> GetSchoolsAsync()
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                return await ctx.Schools.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateSchoolAsync(School school)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Schools.Update(school);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
