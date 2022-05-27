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
    public class AdminDbRepository : IAdminRepository
    {

        private readonly IDbContextFactory<ApplicationDbContext> _factory;
        public AdminDbRepository(IDbContextFactory<ApplicationDbContext>  factory)
        {
            _factory = factory;
        }
        public async Task<Admin> CreateAdminAsync(Admin admin)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Admins.Add(admin);
                await ctx.SaveChangesAsync();
                return admin;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteAdminAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var admin = await ctx.Admins.FirstOrDefaultAsync(ad => ad.AdminID == Guid.Parse(ID));
                ctx.Admins.Remove(admin);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Admin> GetAdminAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var admin = await ctx.Admins.FirstOrDefaultAsync(ad => ad.AdminID == Guid.Parse(ID));
                return admin;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Admin>> GetAdminsAsync()
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                return await ctx.Admins.ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAdminAsync(Admin admin)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Admins.Update(admin);
                await ctx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
