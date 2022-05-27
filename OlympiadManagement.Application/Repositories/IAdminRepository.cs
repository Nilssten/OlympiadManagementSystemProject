using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public interface IAdminRepository
    {
        Task<List<Admin>> GetAdminsAsync();

        Task<Admin> CreateAdminAsync(Admin admin);

        Task UpdateAdminAsync(Admin admin);

        Task<Admin> GetAdminAsync(string ID);

        Task DeleteAdminAsync(string ID);
    }
}
