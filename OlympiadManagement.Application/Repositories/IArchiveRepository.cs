using OlympiadManagement.Core.Aggregates.OlympiadAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public interface IArchiveRepository
    {
        Task<List<Archive>> GetArchivesAsync();

        Task<Archive> CreateArchiveAsync(Archive archive);

        Task UpdateArchiveAsync(Archive archive);

        Task<Archive> GetArchiveAsync(string ID);

        Task DeleteArchiveAsync(string ID);
    }
}
