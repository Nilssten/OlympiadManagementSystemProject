using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public interface IOrganizerRepository 
    {
        Task<List<Organizer>> GetOrganizersAsync();

        Task<Organizer> CreateOrganizerAsync(Organizer organizer);

        Task UpdateOrganizerAsync(Organizer organizer);

        Task<Organizer> GetOrganizerAsync(string ID);

        Task DeleteOrganizerAsync(string ID);
    }
}
