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
    public class ApplicantDbRepository : IApplicantRepository
    {

        private readonly IDbContextFactory<ApplicationDbContext> _factory;
        public ApplicantDbRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }
        public async Task<Applicant> CreateApplicantAsync(Applicant applicant)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Applicants.Add(applicant);
                await ctx.SaveChangesAsync();
                return applicant;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteApplicantAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var applicant = await ctx.Applicants.FirstOrDefaultAsync(ap => ap.ApplicantID == Guid.Parse(ID));
                ctx.Applicants.Remove(applicant);
                await ctx.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Applicant> GetApplicantAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var applicant = await ctx.Applicants.FirstOrDefaultAsync(ap => ap.ApplicantID == Guid.Parse(ID));
                return applicant;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Applicant>> GetApplicantsAsync()
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                return await ctx.Applicants.ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateApplicantAsync(Applicant applicant)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Applicants.Update(applicant);
                await ctx.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
